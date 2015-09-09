using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace NPoco.SqlStoredProcedures
{
    public static class DatabaseSPExtension
    {
        // diagnostic infos
        private static string _lastProcedureName;
        private static string _lastDbType;
        private static object _lastParameter; 

        /// <summary>
        /// Execute a stored procedure with parameter mapping
        /// that return a result set
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TS"></typeparam>
        /// <param name="database"></param>
        /// <param name="storedBean"></param>
        /// <returns></returns>
        public static IEnumerable<T> QueryStoredProcedure<T, TS>(this IDatabase database, TS storedBean)
        {
            // Estract data from annotated bean
            string procedureName = storedBean.GetProcedureName(); // SPUtils.GetProcedureName(storedBean);
            var paramList = storedBean.GetProcedureParameters(database); // SPUtils.GetProcedureParameters(database, storedBean));

            // diagnostic infos
            _lastProcedureName = procedureName;
            _lastDbType = database.DatabaseType.GetProviderName();
            _lastParameter = storedBean;

            // Execute stored procedure
            // Execute stored procedure
            database.OpenSharedConnection();
            try
            {
                IDbCommand sp = database.Connection.CreateCommand();
                sp.CommandType = CommandType.StoredProcedure;
                sp.CommandText = procedureName;
                foreach (var p in paramList) { sp.Parameters.Add(p); }

                var pd = database.PocoDataFactory.ForType(typeof(T));
                IDataReader r;
                try
                {
                    r = sp.ExecuteReader();
                }
                catch (Exception e)
                {
                    OnException(e);
                    throw;
                }

                // remap output params
                storedBean.RemapParams(sp.Parameters);
                // SPUtils.RemapParams(storedBean, sp.Parameters);

                // Read result set
                T instance = default(T);
                using (r)
                {
                    var factory = pd.MappingFactory.GetFactory(0, r.FieldCount, r, instance) as Func<IDataReader, T, T>;
                    while (true)
                    {
                        if (!r.Read()) yield break;
                        if (factory != null)
                        {
                            T resultPoco = factory(r, instance);
                            yield return resultPoco;
                        }
                    }
                }
            }
            finally
            {
                database.CloseSharedConnection();
            }
        }

        /// <summary>
        /// Execute a stored procedure with parameter mapping
        /// that return a single object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TS"></typeparam>
        /// <param name="database"></param>
        /// <param name="storedBean"></param>
        /// <returns></returns>
        public static T SingleStoredProcedure<T, TS>(this IDatabase database, TS storedBean)
        {
            return QueryStoredProcedure<T, TS>(database, storedBean).SingleOrDefault();
        }

        /// <summary>
        /// Execute a stored procedure with parameter mapping
        /// The return is inside the TS Poco Object
        /// </summary>
        /// <typeparam name="TS"></typeparam>
        /// <param name="database"></param>
        /// <param name="storedBean"></param>
        public static void ExecuteStoredProcedure<TS>(this IDatabase database, TS storedBean)
        {
            // Estract data from annotated bean
            string procedureName = storedBean.GetProcedureName(); // SPUtils.GetProcedureName(storedBean);
            var paramList = storedBean.GetProcedureParameters(database); // SPUtils.GetProcedureParameters(database, storedBean));

            // diagnostic infos
            _lastProcedureName = procedureName;
            _lastDbType = database.DatabaseType.GetProviderName();
            _lastParameter = storedBean;

            // Execute stored procedure
            // Execute stored procedure
            database.OpenSharedConnection();
            try
            {
                IDbCommand sp = database.Connection.CreateCommand();
                sp.CommandType = CommandType.StoredProcedure;
                sp.CommandText = procedureName;
                foreach (var p in paramList)
                {
                    sp.Parameters.Add(p);
                }

                sp.ExecuteNonQuery();

                // remap output params
                storedBean.RemapParams(sp.Parameters);
                // SPUtils.RemapParams(storedBean, sp.Parameters);
            }
            catch (Exception e)
            {
                OnException(e);
                throw;
            }
            finally
            {
                database.CloseSharedConnection();
            }
        }

        // Override this to log/capture exceptions
        private static void OnException(Exception x)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine("***** EXCEPTION *****" + Environment.NewLine + Environment.NewLine + x.Message + Environment.NewLine + x.StackTrace);
            System.Diagnostics.Debug.WriteLine("***** LAST COMMAND *****" + Environment.NewLine + Environment.NewLine + _lastParameter.ToStringLinq());
            System.Diagnostics.Debug.WriteLine("***** CONN INFO *****" + Environment.NewLine + Environment.NewLine + "Provider: " + _lastDbType + Environment.NewLine + "Procedure: " + _lastProcedureName);
#endif
        }
    }
}
