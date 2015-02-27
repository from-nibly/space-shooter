using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Assets._scripts {
 // Simple Editor Script that makes Unity Sync with MonoDevelop each time
	// there is a change in the Hierarchy or the Project view.

	class ForceSync : EditorWindow {

		static void Init() {
			var window = EditorWindow.GetWindowWithRect(typeof(ForceSync), new Rect(0,0,100, 100));
			window.Show();
		}
		void OnGUI() {
			if(GUILayout.Button("Sync now!"))
				EditorApplication.ExecuteMenuItem("Assets/Sync MonoDevelop Project");
		}
		void OnHierarchyChange() {
			EditorApplication.ExecuteMenuItem("Assets/Sync MonoDevelop Project");
			Debug.Log("Sync");
		}
		void OnProjectChange() {
			EditorApplication.ExecuteMenuItem("Assets/Sync MonoDevelop Project");
			Debug.Log("Sync");
		}
	}
}
