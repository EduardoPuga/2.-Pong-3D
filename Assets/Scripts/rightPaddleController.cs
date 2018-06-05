using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPaddleController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 rightPaddlePos = this.transform.position;

		if (Input.GetKey (KeyCode.UpArrow)) {
			if (rightPaddlePos.z <= 135) {
				rightPaddlePos.z += 2.0f;
			}
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			if (rightPaddlePos.z >= -135) {
				rightPaddlePos.z -= 2.0f;
			}
		}

		this.transform.position = rightPaddlePos;
	}

	void OnTriggerEnter(Collider collider){

		Debug.Log ("Collision");

		SphereController cubeController = collider.gameObject.GetComponent<SphereController> ();

		bool cubeForward = cubeController.forward;

		cubeForward = !cubeForward;

		cubeController.forward = cubeForward;

		cubeController.recalcularB();

	}
}
