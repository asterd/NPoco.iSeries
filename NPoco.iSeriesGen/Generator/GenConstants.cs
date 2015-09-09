namespace NPoco.iSeriesGen.Generator
{
    public static class GenConstants
    {
        public static string SQLTableInfoQuery = @"
            SELECT 
                    '{0}' AS SchemaName,
                    O.TABLE_NAME AS TableName,
                    C.COLUMN_NAME AS ColumnName,
                    CASE WHEN (C.IS_IDENTITY = 'YES') THEN 1 ELSE 0 END AS isIdentity,
                    CASE WHEN (K.COLUMN_NAME IS NOT NULL) THEN 1 ELSE 0 END AS IsPrimaryKey,
                    C.ORDINAL_POSITION AS ColumnOrder,
                    CASE WHEN C.DATA_TYPE IN ('CHAR', 'VARCHAR') THEN 
                           CAST(C.DATA_TYPE AS VARCHAR(20)) || ' (' || CAST(C.LENGTH AS VARCHAR(20)) || ')'
                    WHEN C.DATA_TYPE IN ('INTEGER', 'NUMERIC', 'SMALLINT', 'DECIMAL', 'BIGINT') THEN 
                           CAST(C.DATA_TYPE AS VARCHAR(20)) || ' (' || CAST(C.NUMERIC_PRECISION AS VARCHAR(20)) || ',' || CAST(C.NUMERIC_SCALE AS VARCHAR(20)) || ')' 
                    ELSE C.DATA_TYPE END AS ComposedDataType,
                    C.DATA_TYPE AS DataType
            FROM
                    {0}.SYSCOLUMNS C
                    INNER JOIN {0}.SYSTABLES O 
                    ON C.TABLE_NAME = O.TABLE_NAME
                    AND C.TABLE_SCHEMA = O.TABLE_SCHEMA
                    LEFT JOIN (
                            SELECT CS.TABLE_NAME, CL.COLUMN_NAME
                            FROM {0}.SYSCST CS
                            LEFT OUTER JOIN {0}.SYSCSTCOL CL
                            USING (CONSTRAINT_SCHEMA, CONSTRAINT_NAME)
                            WHERE CONSTRAINT_TYPE = 'PRIMARY KEY'
                    ) K
                    ON C.TABLE_NAME = K.TABLE_NAME AND C.COLUMN_NAME = K.COLUMN_NAME
            WHERE O.SYSTEM_TABLE = 'N' AND O.TABLE_NAME = '{1}'
        ";

        public static string NativeTableInfoQuery = @"
            SELECT 
                    O.TABLE_SCHEMA AS SchemaName,
                    O.TABLE_NAME AS TableName,
                    C.COLUMN_NAME AS ColumnName,
                    CASE WHEN (C.IS_IDENTITY = 'YES') THEN 1 ELSE 0 END AS isIdentity,
                    CASE WHEN (K.COLUMN_NAME IS NOT NULL) THEN 1 ELSE 0 END AS IsPrimaryKey,
                    C.ORDINAL_POSITION AS ColumnOrder,
                    CASE WHEN C.DATA_TYPE IN ('CHAR', 'VARCHAR') THEN 
                           CAST(C.DATA_TYPE AS VARCHAR(20)) || ' (' || CAST(C.LENGTH AS VARCHAR(20)) || ')'
                    WHEN C.DATA_TYPE IN ('INTEGER', 'NUMERIC', 'SMALLINT', 'DECIMAL', 'BIGINT') THEN 
                           CAST(C.DATA_TYPE AS VARCHAR(20)) || ' (' || CAST(C.NUMERIC_PRECISION AS VARCHAR(20)) || ',' || CAST(C.NUMERIC_SCALE AS VARCHAR(20)) || ')' 
                    ELSE C.DATA_TYPE END AS ComposedDataType,
                    C.DATA_TYPE AS DataType
            FROM
                    QSYS2.SYSCOLUMNS C
                    INNER JOIN QSYS2.SYSTABLES O 
                    ON C.TABLE_NAME = O.TABLE_NAME
                    AND C.TABLE_SCHEMA = O.TABLE_SCHEMA
                    LEFT JOIN (
                            SELECT CS.TABLE_NAME, CL.COLUMN_NAME
                            FROM QSYS2.SYSCST CS
                            LEFT OUTER JOIN QSYS2.SYSCSTCOL CL
                            USING (CONSTRAINT_SCHEMA, CONSTRAINT_NAME)
                            WHERE CONSTRAINT_TYPE = 'PRIMARY KEY'
                    ) K
                    ON C.TABLE_NAME = K.TABLE_NAME AND C.COLUMN_NAME = K.COLUMN_NAME
            WHERE O.SYSTEM_TABLE = 'N' AND O.TABLE_NAME = '{1}' AND O.TABLE_SCHEMA = '{0}'
        ";
    }
}
