using System;

namespace NPoco.iSeriesGen.Generator
{
    [Serializable]
    public class TemplateConfig
    {
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string NameSpace { get; set; }
        public bool IsSqlSchema { get; set; }
        public string DatabaseConnectionURL { get; set; }
        public string DatabaseProvider { get; set; }

        public string GetFmtTableName()
        {
            return GenUtils.ToTitleCase(TableName);
        }

        public string GetTableTypeName()
        {
            return GetFmtTableName() + @"Table";
        }
    }
}
