using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using TemplateEngine;
using UnityTableViewer.Utility;

namespace UnityTableViewer.Generator {
	public class AccessorManagerGenerator : CodeGenerator {
		
		private string ns;
		private string className;
		private IList<string> prefabNames;
		
		public AccessorManagerGenerator(string ns, string className, IList<string> prefabNames) {
			this.ns = ns;
			this.className = className;
			this.prefabNames = prefabNames;
		}
		
		public override void execute() {
			Template target = new Template(AssetPathUtility.AccessorManagerTemplatePath, false);
			target.Set("className", className);
			target.Set("namespace", ns);
			
			string initializeCode = "";
			
			foreach(string name in prefabNames) {
				string line = "			prefabs.Add( new " + NamingRuleUtility.CreateAccessorClassName(name) + "());";
				initializeCode += line + System.Environment.NewLine;
			}
			
			target.Set("initializeCode", initializeCode);
			
			string folderPath = AssetPathUtility.AccessorManagerGeneratePath;
			if(!System.IO.Directory.Exists(folderPath)) {
				System.IO.Directory.CreateDirectory(folderPath);
			}
			
			System.IO.File.WriteAllText(NamingRuleUtility.CreateAccessorManagerGeneratePath(className), target.ToString());
			AssetDatabase.Refresh();
		}
	}
}
