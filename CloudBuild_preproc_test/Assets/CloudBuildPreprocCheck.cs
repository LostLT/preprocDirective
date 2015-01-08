using UnityEngine;
using System.Collections;

public class CloudBuildPreprocCheck : MonoBehaviour {

	public Texture sophie;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {



		#if UNITY_CLOUD_BUILD

		GUI.Label (new Rect(10,10,100,100), "If doge then well-building CloudBuild!");
		GUI.Label (new Rect(100, 10, 300, 300), sophie);
			

		#else

		GUI.Label (new Rect(10,10, 100, 100), "This is not built in CloudBuild!");

		#endif



	}
}
