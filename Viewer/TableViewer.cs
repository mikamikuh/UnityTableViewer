using System;
using UnityEngine;
using System.Collections;
using UnityTableViewer.Provider;

namespace UnityTableViewer.Viewer {
	public class TableViewer {
		
		private IContentProvider contentProvider;
		private ICellProvider cellProvider;
		
		public TableViewer(IContentProvider contentProvider, ICellProvider cellProvider) {
			this.contentProvider = contentProvider;
			this.cellProvider = cellProvider;
		}
		
		public void OnGUI() {
			for(int i = 0; i < contentProvider.Count; i++) {
				GUILayout.BeginHorizontal();
				ICellData content = contentProvider.Contents[i];
				
				for(int j = 0; j < cellProvider.Count; j++) {
					Func<System.Object> accessor = cellProvider.GetCellAccessor(j, content.Data);
					content.Data =  accessor();
				}
				
				GUILayout.EndHorizontal();
			}
		}
	}
}
