using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	/// <summary>
	/// What happens when mouse is pressed
	/// </summary>
	void OnMouseDown(){

		//If the mouse is clicked over the start button, the game starts, and resets kill and weapon values.
		if (collider2D.gameObject.name == "startbutton") {
			Application.LoadLevel (1);
			PlayerPrefs.SetInt ("kills", 0);
			PlayerPrefs.SetInt ("wep", 0);
			PlayerPrefs.Save ();
		}
		//If the mouse is clicked over the quit button the program exits.
		if (collider2D.gameObject.name == "Quitbutton") {
			Debug.Log("I quit");
			Application.Quit ();
		}
	}
}
