using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereController : MonoBehaviour {

	float m = 1.0f;
	float b = 0.0f;

	int intentos;

	bool pause = false;

	public bool forward = true;
	public float delta = 5.0f;

	Vector3 pos = new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pause) {
			pos = this.transform.position;

			pos.z = m * pos.x + b;

			if (pos.x > 270.0f) {
				pos.x = 0;
				pos.y = 0;
				pos.z = 0;
				recalcularB ();
				pause = false;
				intentos += 1;
			}
			if (pos.x < -270.0f) {
				pos.x = 0;
				pos.y = 0;
				pos.z = 0;
				recalcularB ();
				pause = false;
				intentos += 1;
			}
			if (pos.z > 190.0f) {
				recalcularB ();
			}
			if (pos.z < -190.0f) {
				recalcularB ();
			}

			if (intentos == 5) {
				Level_Final ();
			}

			if (forward) {
				pos.x += delta;
				pos.z += delta;
			} else {
				pos.x -= delta;
				pos.z -= delta;
			}
			this.transform.position = pos;
		}

		if (Input.GetKey (KeyCode.Space)) {
			pause = true;
		}
	}

	public void recalcularB(){
		m = m * -1;
		b = pos.z - m * pos.x;
	}

	void Level_Final(){
		SceneManager.LoadScene (2);
	}

	void OnGUI (){
		if (GUI.Button (new Rect (Screen.width / 2.5f, 0, Screen.width / 5, Screen.height/ 10), "Space To Start")) {
		}
	}
}
