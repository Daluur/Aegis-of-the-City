using UnityEngine;
using System.Collections;

public class eRangedpayerinrange : MonoBehaviour {

	private Vector2 plPosition;

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			audio.Play (); //plays a sound, to say that you are in range of the enemy
			plPosition.x = other.transform.position.x;
			plPosition.y = other.transform.position.y;
			transform.root.gameObject.SendMessage("playerInRange", plPosition); //tells the enemy that the player is in range, and his position
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			transform.root.gameObject.SendMessage("playerNotInRange"); //tells the enemy, that the player is no longer in range
		}
	}
}
