using UnityEngine;
using UnityEditor;
using System.Collections;

namespace UnityTableViewer.Generator {
	public abstract class CodeGenerator : ICodeGenerator {
		public abstract void execute();
		
		protected void GenerateCode(string folderPath, string generatePath, string snippet) {
			if(!System.IO.Directory.Exists(folderPath)) {
				System.IO.Directory.CreateDirectory(folderPath);
			}
			
			System.IO.File.WriteAllText(generatePath, snippet);
			AssetDatabase.Refresh();
		}
	}
}