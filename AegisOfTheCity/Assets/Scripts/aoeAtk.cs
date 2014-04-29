using UnityEngine;
using System.Collections;

public class aoeAtk : MonoBehaviour {
	// The amount of damage the attack does
	public int eDmg = 10;
	
	

	void Start () {
		//Is destroyed 1 second after being initialized
		//plays a sound
		audio.Play ();
		Destroy (gameObject, 1);
	}
	

	void Update () {
		
	}

	//When the trigger collides with the player, send a "message" which deals damage to the player
	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.SendMessage("takeDmg",eDmg);
		} 
	}
}
