using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI () {

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 2.0f - 150, Screen.width / 5, Screen.height/ 10), "(R)ESTART")) {
			SceneManager.LoadScene (1);
		}
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene (1);
		}

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 2.0f, Screen.width / 5, Screen.height/ 10), "(M)ENU")) {
			SceneManager.LoadScene (0);
		}
		if (Input.GetKey (KeyCode.M)) {
			SceneManager.LoadScene (0);
		}

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 2.0f + 150, Screen.width / 5, Screen.height/ 10), "(E)XIT")) {
			Application.Quit();
		}
		if (Input.GetKey (KeyCode.E)) {
			Application.Quit();
		}
	}
}