using UnityEngine;
using System.Collections;

namespace UnityTableViewer.Utility {
	public class NamingRuleUtility {
		
		public static string CreateAccessorClassName(string prefabName) {
			return prefabName + "DataAccessor";
		}
		
		public static string CreateAccessorManagerGeneratePath(string className) {
			return AssetPathUtility.AccessorManagerGeneratePath + "/" + className + "AccessorManager.cs";
		}
	}
}