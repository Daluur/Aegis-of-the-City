using UnityEngine;
using System.Collections;

public class eHealthBar : MonoBehaviour {


	// This script will make a GUITexture follow a transform.
	



	void Update ()
		
	{

		//The position of the object which the GUITexture should follow.
		var wantedPos = Camera.main.WorldToViewportPoint (transform.parent.position);
		//Transforms the position of the GUITexture so that it will follow the object it is attached to.
		transform.position = wantedPos;

		
	}
	/// <summary>
	/// Adjusts the health bar of the enemy 
	/// </summary>
	/// <param name="dmg">Dmg.</param>
	void adjustHPBar(int dmg){
		//How much one damage is on the enemies health bar
		float oneDMGonTheHealthbar = 0.0038f;
		//Resizes the health bar of the enemy hit.
		gameObject.transform.localScale = new Vector3 (-(dmg*oneDMGonTheHealthbar), 0f, 0f);
		}


}
