using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NPoco
{
    public class AutoSelectHelper
    {
        private static readonly Regex RxSelect = new Regex(@"\A\s*(SELECT|EXECUTE|CALL|EXEC)\s", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Multiline);
        private static readonly Regex RxFrom = new Regex(@"\A\s*FROM\s", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Multiline);

        public static string AddSelectClause<T>(Database database, string sql)
        {
            if (sql.StartsWith(";"))
                return sql.Substring(1);

            if (!RxSelect.IsMatch(sql))
            {
                var pd = database.PocoDataFactory.ForType(typeof(T));
                var tableName = database.DatabaseType.EscapeTableName(pd.TableInfo.TableName);
                var columns = pd.QueryColumns.Select(c =>
                {
                    return database.DatabaseType.EscapeSqlIdentifier(c.Value.ColumnName) +
                           (!string.IsNullOrEmpty(c.Value.ColumnAlias)
                                ? " AS " + database.DatabaseType.EscapeSqlIdentifier(c.Value.ColumnAlias)
                                : "");
                });
                string cols = String.Join(", ", columns.ToArray());
                if (!RxFrom.IsMatch(sql))
                    sql = String.Format("SELECT {0} FROM {1} {2}", cols, tableName, sql);
                else
                    sql = String.Format("SELECT {0} {1}", cols, sql);
            }
            return sql;
        }
    }
}
