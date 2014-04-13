using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){

		if (collider2D.gameObject.name == "startbutton")
						Application.LoadLevel (1);
		if (collider2D.gameObject.name == "Quitbutton") {
			Debug.Log("I quit");
			Application.Quit ();

				}
	}
	
}
