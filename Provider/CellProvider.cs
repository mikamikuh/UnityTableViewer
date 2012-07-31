using System;
using UnityEngine;
using UnityEditor;
using System.Collections;

namespace UnityTableViewer.Provider {
	public abstract class CellProvider : ICellProvider {
		
		public int Count() {
			return 0;
		}

		public string GetLabel(int col, System.Object obj) {
			return obj.ToString();
		}
		
		public Func<System.Object> GetCellAccessor(int col, System.Object obj) {
			if(obj.GetType() == typeof(string)) {
				return () => { return EditorGUILayout.TextField((string)obj, GUILayout.ExpandWidth(true)); };
			} else if(obj.GetType() == typeof(int)) {
				return () => { return int.Parse (EditorGUILayout.TextField (((int)obj).ToString (), GUILayout.ExpandWidth(true))); };
			} else if(obj.GetType() == typeof(float)) {
				return () => { return float.Parse (EditorGUILayout.TextField (((float)obj).ToString (), GUILayout.ExpandWidth(true))); };
			}
			
			return null;
		}
	}
}