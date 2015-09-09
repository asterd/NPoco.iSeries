namespace NPoco.iSeriesGen.Generator
{
    public class PocoTableInfo
    {
        [Column("SCHEMANAME")]
        public string SchemaName { get; set; }
        [Column("TABLENAME")]
        public string TableName { get; set; }
        [Column("COLUMNNAME")]
        public string ColumnName { get; set; }
        [Column("ISIDENTITY")]
        public int Identity { get; set; }
        [Column("ISPRIMARYKEY")]
        public int Primary { get; set; }
        [Column("COLUMNORDER")]
        public int ColumnOrder { get; set; }
        [Column("COMPOSEDDATATYPE")]
        public string ComposedDataType { get; set; }
        [Column("DATATYPE")]
        public string DataType { get; set; }

        public bool IsIdentityColumn()
        {
            return Identity == 1;
        }

        public bool IsPrimaryKeyColumn()
        {
            return Primary == 1;
        }
    }
}
