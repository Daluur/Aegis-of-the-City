using UnityEngine;
using System.Collections;

public class healthpickUp : MonoBehaviour {

	public int healAmount = 15;

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "Player") {
			coll.SendMessage("takeDmg", -healAmount); //deals minus damage to the player (healing him)
			Destroy(gameObject);
		}
	}

}
