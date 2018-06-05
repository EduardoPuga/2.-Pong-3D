using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI (){

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 2.2f, Screen.width / 5, Screen.height/ 10), "(S)TART")) {

			SceneManager.LoadScene (1);
		}
		if (Input.GetKey (KeyCode.S)) {
			SceneManager.LoadScene (1);
		}
	}

}
