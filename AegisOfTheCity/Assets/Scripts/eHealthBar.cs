using UnityEngine;
using System.Collections;

public class eHealthBar : MonoBehaviour {



	public int healthorz;
	public float sizeofhealthbar = 0.0114f;
	public float oneDMGonTheHealthbar;

	void start(){


	}
	void Update ()
		
	{

		//The position of the object which the GUITexture should follow.
		var wantedPos = Camera.main.WorldToViewportPoint (transform.parent.position);
		//Transforms the position of the GUITexture so that it will follow the object it is attached to.
		transform.position = wantedPos;

		
	}
	/// <summary>
	/// Max HP of an enemy is set for healthbars
	/// </summary>
	/// <param name="HP">H.</param>
	void maxHP(int HP){
		//The maximum health of the enemy
		healthorz = HP;
		//How much one damage is on the enemies health bar
		oneDMGonTheHealthbar = sizeofhealthbar/healthorz;
	
	}

	/// <summary>
	/// Adjusts the health bar of the enemy 
	/// </summary>
	/// <param name="dmg">Dmg.</param>
	void adjustHPBar(int dmg){
		//Resizes the health bar of the enemy hit.
		gameObject.transform.localScale -= new Vector3 ((dmg*oneDMGonTheHealthbar), 0f, 0f);
		}


}
