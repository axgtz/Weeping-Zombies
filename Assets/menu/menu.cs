using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public void Nueva_partida(){
		Application.LoadLevel(7);
		//Debug.Log("partida");

	}


	public void Salir(){
		Application.Quit();
		Debug.Log("salir");

	}
}
