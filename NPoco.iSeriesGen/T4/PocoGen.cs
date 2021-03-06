﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NPoco.iSeriesGen.T4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NPoco;
    using NPoco.iSeriesGen.Generator;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class PocoGen : PocoGenBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            
            #line 13 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
  
	// System.Diagnostics.Debugger.Launch();
	var namespaceName    = ConfigObject.NameSpace;
	var tableSchema      = ConfigObject.TableSchema;  
	var tableName        = ConfigObject.TableName; 
    var tableType        = ConfigObject.GetTableTypeName();
    var fmtTableName     = ConfigObject.GetFmtTableName();
	bool isSqlTable      = ConfigObject.IsSqlSchema; 


	IDatabase db = new Database(ConfigObject.DatabaseConnectionURL, ConfigObject.DatabaseProvider);
	List<PocoTableInfo> tableColumnData;

	if (isSqlTable)
	{
		IEnumerable<PocoTableInfo> data =
			db.Query<PocoTableInfo>(String.Format(GenConstants.SQLTableInfoQuery, tableSchema, tableName), null);
		tableColumnData = data.ToList();
	}
	else
	{
		IEnumerable<PocoTableInfo> data =
			db.Query<PocoTableInfo>(String.Format(GenConstants.NativeTableInfoQuery, tableSchema, tableName), null);
		tableColumnData = data.ToList();
	}

            
            #line default
            #line hidden
            this.Write("using NPoco; \r\nusing System;\r\nusing System.Collections.Generic;\r\n\r\nnamespace ");
            
            #line 43 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(namespaceName));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\r\n    #region ");
            
            #line 46 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fmtTableName));
            
            #line default
            #line hidden
            this.Write(" POCO definition\r\n\r\n\t[TableName(\"");
            
            #line 48 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableSchema));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 48 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 49 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
 
foreach(PocoTableInfo pti in tableColumnData) {
	if (pti.IsPrimaryKeyColumn()) { 

            
            #line default
            #line hidden
            this.Write("\t[PrimaryKey(\"");
            
            #line 53 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pti.ColumnName));
            
            #line default
            #line hidden
            this.Write("\")] \r\n");
            
            #line 54 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
	
    }
} 

            
            #line default
            #line hidden
            this.Write(" \r\n\tpublic class ");
            
            #line 58 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 60 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
	
foreach(PocoTableInfo pti in tableColumnData) { 

            
            #line default
            #line hidden
            this.Write("\t\t[Column(\"");
            
            #line 63 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pti.ColumnName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\t\tpublic ");
            
            #line 64 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenUtils.ToCsDataType(pti.DataType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 64 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenUtils.ToTitleCase(pti.ColumnName)));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 65 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
	
} 

            
            #line default
            #line hidden
            this.Write("\t\r\n        /// <summary>\r\n        /// Return the list of columns \r\n        /// </" +
                    "summary>\r\n        /// <returns></returns>\r\n        public static string[] GetCol" +
                    "umnsList()\r\n\t    {\r\n\t        var colList = new List<string>();\r\n");
            
            #line 75 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
	
foreach(PocoTableInfo pti in tableColumnData) { 

            
            #line default
            #line hidden
            this.Write("\t\t    colList.Add(\"");
            
            #line 78 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenUtils.ToTitleCase(pti.ColumnName)));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 79 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
	
} 

            
            #line default
            #line hidden
            this.Write(@"	        return colList.ToArray();
	    }

        /// <summary>
        /// Get row as TAB separated string
        /// Utility method for WINDEV bridge
        /// </summary>
        /// <returns></returns>
	    public string GetRowItem()
	    {
	        var sb = new StringBuilder();
");
            
            #line 93 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
	
foreach(PocoTableInfo pti in tableColumnData) { 

            
            #line default
            #line hidden
            this.Write("\t\t    sb.Append(");
            
            #line 96 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenUtils.ToTitleCase(pti.ColumnName)));
            
            #line default
            #line hidden
            this.Write(" + \"\\t\");\r\n");
            
            #line 97 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
	
} 

            
            #line default
            #line hidden
            this.Write("\t        return sb.ToString();\r\n\t    }\r\n    }\r\n\r\n    #endregion ");
            
            #line 104 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fmtTableName));
            
            #line default
            #line hidden
            this.Write(" POCO definition\r\n\r\n    #region ");
            
            #line 106 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fmtTableName));
            
            #line default
            #line hidden
            this.Write(" CRUD Manager\r\n\r\n    public class ");
            
            #line 108 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fmtTableName));
            
            #line default
            #line hidden
            this.Write("CRUD\r\n    {\r\n        private readonly IDatabase _database;\r\n\r\n        public ");
            
            #line 112 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fmtTableName));
            
            #line default
            #line hidden
            this.Write("CRUD(IDatabase database)\r\n        {\r\n            _database = database;\r\n        }" +
                    "\r\n\r\n        /// <summary>\r\n        /// Select *\r\n        /// </summary>\r\n       " +
                    " /// <returns></returns>\r\n        public List<");
            
            #line 121 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write(@"> SelectAll()
        {
            return Select("""", null);
        }

        /// <summary>
        /// Select items with condition
        /// </summary>
        /// <param name=""condition""></param>
        /// <param name=""parameters""></param>
        /// <returns></returns>
        public List<");
            
            #line 132 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write("> Select(string condition, params object[] parameters)\r\n        {\r\n            if" +
                    " (String.IsNullOrEmpty(condition)) \r\n                return _database.Fetch<");
            
            #line 135 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write(">();\r\n            return _database.Fetch<");
            
            #line 136 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write(">(condition, parameters);\r\n        }\r\n\r\n        /// <summary>\r\n        /// Insert" +
                    " new item inside database table\r\n        /// </summary>\r\n        /// <param name" +
                    "=\"item\"></param>\r\n        /// <returns></returns>\r\n        public object Insert(" +
                    "");
            
            #line 144 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write(@" item)
        {
            return _database.Insert(item);
        }

        /// <summary>
        /// Insert new item inside database table
        /// </summary>
        /// <param name=""item""></param>
        /// <returns></returns>
        public int Update(");
            
            #line 154 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write(" item)\r\n        {\r\n            return _database.Update(item);\r\n        }\r\n\r\n     " +
                    "   /// <summary>\r\n        /// Delete using full poco\r\n        /// </summary>\r\n  " +
                    "      /// <param name=\"item\"></param>\r\n        public int Delete(");
            
            #line 163 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write(@" item)
        {
            return _database.Delete(item);
        }

        /// <summary>
        /// Delete item with primary key value
        /// </summary>
        /// <param name=""primaryKeyValue""></param>
        /// <returns></returns>
        public int Delete(object primaryKeyValue)
        {
            return _database.Delete<");
            
            #line 175 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tableType));
            
            #line default
            #line hidden
            this.Write(">(primaryKeyValue);\r\n        }\r\n    }\r\n\r\n    #endregion ");
            
            #line 179 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fmtTableName));
            
            #line default
            #line hidden
            this.Write(" CRUD Manager\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
        
        #line 1 "C:\Progetti\vs2012\Standalone\NPoco.iSeries\NPoco.iSeriesGen\T4\PocoGen.tt"

private global::NPoco.iSeriesGen.Generator.TemplateConfig _ConfigObjectField;

/// <summary>
/// Access the ConfigObject parameter of the template.
/// </summary>
private global::NPoco.iSeriesGen.Generator.TemplateConfig ConfigObject
{
    get
    {
        return this._ConfigObjectField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool ConfigObjectValueAcquired = false;
if (this.Session.ContainsKey("ConfigObject"))
{
    if ((typeof(global::NPoco.iSeriesGen.Generator.TemplateConfig).IsAssignableFrom(this.Session["ConfigObject"].GetType()) == false))
    {
        this.Error("The type \'NPoco.iSeriesGen.Generator.TemplateConfig\' of the parameter \'ConfigObje" +
                "ct\' did not match the type of the data passed to the template.");
    }
    else
    {
        this._ConfigObjectField = ((global::NPoco.iSeriesGen.Generator.TemplateConfig)(this.Session["ConfigObject"]));
        ConfigObjectValueAcquired = true;
    }
}
if ((ConfigObjectValueAcquired == false))
{
    string parameterValue = this.Host.ResolveParameterValue("Property", "PropertyDirectiveProcessor", "ConfigObject");
    if ((string.IsNullOrEmpty(parameterValue) == false))
    {
        global::System.ComponentModel.TypeConverter tc = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::NPoco.iSeriesGen.Generator.TemplateConfig));
        if (((tc != null) 
                    && tc.CanConvertFrom(typeof(string))))
        {
            this._ConfigObjectField = ((global::NPoco.iSeriesGen.Generator.TemplateConfig)(tc.ConvertFrom(parameterValue)));
            ConfigObjectValueAcquired = true;
        }
        else
        {
            this.Error("The type \'NPoco.iSeriesGen.Generator.TemplateConfig\' of the parameter \'ConfigObje" +
                    "ct\' did not match the type of the data passed to the template.");
        }
    }
}
if ((ConfigObjectValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("ConfigObject");
    if ((data != null))
    {
        if ((typeof(global::NPoco.iSeriesGen.Generator.TemplateConfig).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'NPoco.iSeriesGen.Generator.TemplateConfig\' of the parameter \'ConfigObje" +
                    "ct\' did not match the type of the data passed to the template.");
        }
        else
        {
            this._ConfigObjectField = ((global::NPoco.iSeriesGen.Generator.TemplateConfig)(data));
        }
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class PocoGenBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
