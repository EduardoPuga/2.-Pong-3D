using UnityEngine;
using System.Collections;

public class PuntuacionDerecha : MonoBehaviour {

	public int puntuacionDerecha = 0;
	public TextMesh marcadorDerecho;

	void start () {

		ActualizarMarcador ();

	}

	void OnTriggerEnter(Collider collider){
		/*print ("Trigger");
		print (other);*/

		puntuacionDerecha = puntuacionDerecha + 1;
		ActualizarMarcador ();
		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}

	void ActualizarMarcador(){

		marcadorDerecho.text = puntuacionDerecha.ToString ();
	}
}
