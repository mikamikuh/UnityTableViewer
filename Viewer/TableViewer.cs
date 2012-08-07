using System;
using UnityEngine;
using System.Collections;
using UnityTableViewer.Provider;

namespace UnityTableViewer.Viewer {
	public class TableViewer {
		
		private IContentProvider contentProvider;
		public IContentProvider ContentProvider {
			get{ return contentProvider; }
			set{ contentProvider = value; }
		}
		
		private ICellProvider cellProvider;
		public ICellProvider CellProvider {
			get{ return cellProvider; }
			set{ cellProvider = value; }
		}
		
		public void OnGUI() {
			DrawHeader();
			
			for(int i = 0; i < contentProvider.Count; i++) {
				ICellData content = contentProvider.Contents[i];
								
				GUILayout.BeginHorizontal();
				
				DrawNameCell(content);
				for(int j = 0; j < cellProvider.Count; j++) {
					string label = cellProvider.GetLabel(j, content);
					Func<System.Object> accessor = cellProvider.GetCellAccessor( content.GetData(label) );
					content.SetData (accessor(), label);
				}
				
				GUILayout.EndHorizontal();
			}
		}
		
		private void DrawNameCell(ICellData data) {
			string before = data.Name;
			string after = "";
			
			after = GUILayout.TextField (data.Name);
			
			if(before != after) {
				data.Name = after;
			}
		}
		
		private void DrawHeader() {
			GUILayout.BeginHorizontal();
			GUILayout.Label("Name");
			foreach(string name in cellProvider.GetAllLabel()) {
				GUILayout.Label (name);
			}
			GUILayout.EndHorizontal();
		}
	}
}
