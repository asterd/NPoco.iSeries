using System;

namespace NPoco.SqlStoredProcedures.Annotation
{
    /// <summary>
    /// Name of the stored procedure
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]   
    public class SPNameAttribute : Attribute
    {
        public string Name { get; private set; }

        public SPNameAttribute(string name)
        {
            Name = name;
        }
    }
}
