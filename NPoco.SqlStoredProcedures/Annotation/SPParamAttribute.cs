using System;
using System.Data;

namespace NPoco.SqlStoredProcedures.Annotation
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
    public class SPParamAttribute : Attribute
    {
        public string Name { get; set; }
        public ParameterDirection Direction { get; set; }
        public bool Required { get; set; }

        public SPParamAttribute()
        {
            Required = false;
        }
    }
}
