using UnityEngine;
using System.Collections;

public class PuntuacionIzquierda : MonoBehaviour {

	public int puntuacionIzquierda = 0;
	public TextMesh marcadorIzquierdo;

	void start () {

		ActualizarMarcador ();

	}

	void OnTriggerEnter(Collider collider){
		/*print ("Trigger");
		print (other);*/
		
		puntuacionIzquierda = puntuacionIzquierda + 1;
		ActualizarMarcador ();
		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}

	void ActualizarMarcador(){

		marcadorIzquierdo.text = puntuacionIzquierda.ToString ();
	}
}
