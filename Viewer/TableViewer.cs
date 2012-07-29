using UnityEngine;
using System.Collections;

namespace UnityTableViewer {
	public class UnityTableViewer {
		
		private IPrefabProvider provider;
		
		public UnityTableViewer(IPrefabProvider provider) {
			this.provider = provider;
		}
		
		public void OnGUI() {
			for(int i = 0; i < provider.RowCount; i++) {
				GUILayout.BeginHorizontal();
				Object prefab = provider.Prefabs[i];
				for(int j = 0; j < provider.ColCount; j++) {
					//Component comp = prefab.GetComponent ("GeneratedClassName");
					//comp.aaa = 1;
				}
				GUILayout.EndHorizontal();
			}
		}
	}
}
