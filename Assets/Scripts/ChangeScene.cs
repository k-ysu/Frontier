using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToCorridor () {
		 GameObject obj = GameObject.FindGameObjectWithTag("SceneCtr");
		SceneStatic scene_mgr = obj.GetComponents<SceneStatic> () [0];
		scene_mgr.GoToCorridor ();
	}
	public void GoToClassRoom1 () {
		GameObject obj = GameObject.FindGameObjectWithTag("SceneCtr");
		SceneStatic scene_mgr = obj.GetComponents<SceneStatic> () [0];
		scene_mgr.GoTocCassroom (1);
	}


}
