using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/// <summary>
	/// What happens when mouse is pressed
	/// </summary>
	void OnMouseDown(){

		//If the mouse is clicked over the start button, the game starts.
		if (collider2D.gameObject.name == "startbutton")
						Application.LoadLevel (1);
		//If the mouse is clicked over the quit button the program exits.
		if (collider2D.gameObject.name == "Quitbutton") {
			Debug.Log("I quit");
			Application.Quit ();

				}
	}
	
}
