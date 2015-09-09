using System.Globalization;

namespace NPoco.iSeriesGen.Generator
{
    public static class GenUtils
    {
        public static string ToTitleCase(string inputString)
        {
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputString.ToLower());
            return titleCase.Replace("_", "");
        }

        public static string ToCsDataType(string dbType)
        {
            switch (dbType)
            {
                case "INTEGER":
                    return "int";
                case "VARCHAR":
                    return "string";
                case "CHAR":
                    return "string";
                case "DECIMAL":
                    return "int";
                case "NUMERIC":
                    return "double";
                default:
                    return "object";
            }
        }
    }
}
