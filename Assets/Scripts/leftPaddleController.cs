using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPaddleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 leftPaddlePos = this.transform.position;

		if (Input.GetKey (KeyCode.W)) {
			if (leftPaddlePos.z <= 135) {
				leftPaddlePos.z += 2.0f;
			}
		}
		else if (Input.GetKey (KeyCode.S)) {
			if (leftPaddlePos.z >= -135) {
				leftPaddlePos.z -= 2.0f;
			}
		}

		this.transform.position = leftPaddlePos;
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
