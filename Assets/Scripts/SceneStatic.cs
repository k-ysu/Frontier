using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneStatic : MonoBehaviour {

	static SceneStatic _instance;
	public int current_class_room = 0;
	public bool created = false;
	public Vector3 cam_postion;
	public Quaternion cam_rotation;
	public bool is_move_cam = false;

	public static SceneStatic managerInstance
	{
		get
		{
			if(_instance == null)
			{
				_instance = GameObject.FindGameObjectWithTag("SceneCtr").GetComponent<SceneStatic>();
				//Tell unity not to destroy this object when loading a new scene!
				DontDestroyOnLoad(_instance.gameObject);
			}
			return _instance;
		}
	}

	void Awake()
	{
		if(_instance == null)
		{
			//If I am the first instance, make me the Singleton
			_instance = this;
			DontDestroyOnLoad (this);
		}
		else
		{
			//If a Singleton already exists and you find
			//another reference in scene, destroy it!
			if(this != _instance)
				Destroy(this.gameObject);
		}
	}


	public void GoTocCassroom (int number){
		current_class_room = number;
		//Application.LoadLevel("Classroom");
		SceneManager.LoadScene("Classroom");
	}

	public void GoToCorridor (){
		current_class_room = 0;
		cam_postion = new Vector3 (-16.0f, 1.25f, 0.25f);
		cam_rotation = new Quaternion (0, 90, 0, 0);
		is_move_cam = true;
		//Application.LoadLevel("Corridor");
		SceneManager.LoadScene("Corridor");
	}
}
