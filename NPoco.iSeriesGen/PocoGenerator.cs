using System;
using System.Collections.Generic;
using System.IO;
using NPoco.iSeriesGen.Generator;
using NPoco.iSeriesGen.T4;

namespace NPoco.iSeriesGen
{
    public class PocoGenerator
    {
        /// <summary>
        /// Generate Poco object from TemplateConfig
        /// </summary>
        /// <param name="cfg"></param>
        /// <param name="outputPath"></param>
        public static void GeneratePoco(TemplateConfig cfg, string outputPath = "")
        {
            var templateInstance = new PocoGen { Session = new Dictionary<string, object> { { "ConfigObject", cfg } } };
            templateInstance.Initialize();
            var generatedCode = templateInstance.TransformText();

            File.WriteAllText(Path.Combine(outputPath, cfg.GetFmtTableName()) + @".cs", generatedCode);
        }

        /// <summary>
        /// Generate Poco from table configurations
        /// </summary>
        /// <param name="classNamespace"></param>
        /// <param name="tableSchema"></param>
        /// <param name="tableName"></param>
        /// <param name="isSqlSchema"></param>
        /// <param name="dbServer"></param>
        /// <param name="dbUser"></param>
        /// <param name="dbPassword"></param>
        /// <param name="outputPath"></param>
        public static void GeneratePoco(
            string classNamespace, string tableSchema, 
            string tableName, bool isSqlSchema, 
            string dbServer, string dbUser, string dbPassword, 
            string outputPath = "")
        {
            var cfg = new TemplateConfig
            {
                TableSchema = tableSchema,
                TableName = tableName,
                NameSpace = classNamespace,
                IsSqlSchema = isSqlSchema,
                DatabaseConnectionURL = String.Format("Data Source={0};UserID={1};Password={2};", dbServer, dbUser, dbPassword),
                DatabaseProvider = "IBM.Data.DB2.iSeries"
            };
            GeneratePoco(cfg, outputPath);
        }
    }
}
