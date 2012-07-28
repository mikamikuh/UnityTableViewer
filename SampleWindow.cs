using System;
using System.Threading;
using UnityEngine;
using UnityEditor;
using System.Collections;
using TemplateEngine;

public class SampleWindow : EditorWindow {
	private Boolean flag = false;
    
    [MenuItem ("Window/My Window %g")]
    static void Init () {
         MyWindow window = (MyWindow)EditorWindow.GetWindow (typeof (MyWindow));
    }
    
    void OnGUI () {
		if(GUILayout.Button("Click")){
			Template target = new Template("Assets/Templates/csharp.txt", false);
			target.Set("className", "GenerateClassName");
			target.Set("extendClassName", "MonoBehaviour");
			System.IO.File.WriteAllText("Assets/GenerateClassName.cs", target.ToString());
			Debug.Log (target.ToString());
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