using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using NPoco.SqlStoredProcedures.Annotation;

namespace NPoco.SqlStoredProcedures
{
    public static class SPUtils
    {
        /// <summary>
        /// Generic to String with Linq
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string ToStringLinq(this object o)
        {
            return o.GetType().FullName
                + Environment.NewLine
                + string.Join(Environment.NewLine, (from p in o.GetType().GetProperties()
                                                    select string.Format("{0}{1}{2}", p.Name, ':', p.GetValue(o, null))));
        }

        /// <summary>
        /// Get the procedure name from object annotation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="spoco"></param>
        /// <returns></returns>
        public static string GetProcedureName<T>(this T spoco)
        {
            var nameAttribute = (SPNameAttribute)Attribute.GetCustomAttribute(spoco.GetType(), typeof(SPNameAttribute));
            if (nameAttribute == null) throw new ArgumentException("Procedure name must be defined!");
            return nameAttribute.Name;
        }
        
        /// <summary>
        /// Get the procedure parameter from attributes and return 
        /// as a IDataParamter array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="database"></param>
        /// <param name="spoco"></param>
        /// <returns></returns>
        public static IDataParameter[] GetProcedureParameters<T>(this T spoco, IDatabase database)
        {
            var paramsList = new List<IDataParameter>();

            foreach (PropertyInfo field in spoco.GetType().GetProperties())
            {
                var p = (SPParamAttribute)Attribute.GetCustomAttribute(field, typeof(SPParamAttribute));
                if (p != null)
                {
                    IDataParameter par = database.CreateParameter();
                    par.Direction = p.Direction;
                    par.ParameterName = p.Name;
                    if (p.Direction == ParameterDirection.Input)
                    {
                        par.Value = field.GetValue(spoco, null);
                    }
                    paramsList.Add(par);
                }
            }

            return paramsList.ToArray();
        }

        /// <summary>
        /// Remap Output & InputOutput param in input T bean
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="spoco"></param>
        /// <param name="parameters"></param>
        public static void RemapParams<T>(this T spoco, IDataParameterCollection parameters)
        {
            foreach (PropertyInfo field in spoco.GetType().GetProperties())
            {
                var pa = (SPParamAttribute)Attribute.GetCustomAttribute(field, typeof(SPParamAttribute));
                foreach (IDataParameter par in parameters)
                {
                    if (par.Direction != ParameterDirection.Input && par.ParameterName.Equals(pa.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        object propertyVal = Convert.ChangeType(par.Value, field.PropertyType);

                        field.SetValue(spoco, propertyVal, null);
                        break;
                    }
                }
            }
        }
    }
}
