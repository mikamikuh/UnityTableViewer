using System;
using System.Threading;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using TemplateEngine;
using UnityTableViewer.Generator;

public class SampleWindow : EditorWindow {
	private Boolean flag = false;
    
    [MenuItem ("Window/Sample Window %g")]
    static void Init () {
         SampleWindow window = (SampleWindow)EditorWindow.GetWindow (typeof (SampleWindow));
    }
    
    void OnGUI () {
		if(GUILayout.Button("Generate AccessorManager")) {
			IList<string> prefabNames = new List<string>();
			DirectoryInfo info = new DirectoryInfo("Assets/SourcePrefab/");
			foreach(FileInfo f in info.GetFiles()) {
				prefabNames.Add (f.Name.Split('.')[0]);
			}
			
			//UnityEngine.Object[] objects = AssetDatabase.LoadAllAssetsAtPath("Assets/SourcePrefab/");
			//UnityEngine.Object obj = AssetDatabase.LoadAssetAtPath("Assets/SourcePrefab/Cube", typeof(GameObject));
			//Debug.Log (obj.name);
			//IList<UnityEngine.Object> prefabs = new List<UnityEngine.Object>(objects);
			ICodeGenerator generator = new AccessorManagerGenerator("Test.Generate", "Sample", prefabNames);
			generator.execute();
		}
		
		if(GUILayout.Button("Click")){
			AssetDatabase.ImportAsset("Assets/GenerateClassName.cs");
			AssetDatabase.Refresh();
			flag = true;
		}
    }
	
	void Update() {
		if(!EditorApplication.isCompiling && flag) {
			GameObject gameObject = new GameObject();
			Component comp = gameObject.AddComponent("GenerateClassName");
//			gameObject.GetComponent<GenerateClassName>
//			gameObject.test = 0;
			UnityEngine.Object prefab = EditorUtility.CreateEmptyPrefab("Assets/MyObject.prefab");
			EditorUtility.ReplacePrefab(gameObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
			flag = false;
		}
	}
}