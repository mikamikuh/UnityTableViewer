using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityTableViewer.Utility;
using TemplateEngine;

namespace UnityTableViewer.Generator {
	public class DataScriptGenerator : CodeGenerator {
		
		private string ns;
		private string className;
		private IDictionary<string, string> variables;
		
		public DataScriptGenerator(string ns, string className, IDictionary<string, string> variables) {
			this.ns = ns;
			this.className = className;
			this.variables = variables;
		}
		
		public override void execute() {
			Template target = new Template(AssetPathUtility.DataScriptTemplatePath, false);
			target.Set("className", className);
			target.Set("namespace", ns);
			
			string variableCode = "";
			
			foreach(KeyValuePair<string, string> pair in variables) {
				string line = "		public " + pair.Value + " " + pair.Key + ";";
				variableCode += line + System.Environment.NewLine;
			}
			
			target.Set("variables", variableCode);
			
			string folderPath = AssetPathUtility.DataScriptGeneratePath;
			string generatePath = NamingRuleUtility.CreateDataScriptGeneratePath(className);
			GenerateCode(folderPath, generatePath, target.ToString());
		}
	}
}