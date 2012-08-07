using System;
using UnityEngine;
using UnityEditor;
using System.Collections;

namespace UnityTableViewer.Provider {
	public abstract class CellProvider : ICellProvider {
		
		public virtual int Count {
			get { return 0; }
		}

		public virtual string GetLabel(int col, System.Object obj) {
			return obj.ToString();
		}
		
		public virtual string[] GetAllLabel() {
			return null;
		}
		
		public Func<System.Object> GetCellAccessor(System.Object obj) {
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