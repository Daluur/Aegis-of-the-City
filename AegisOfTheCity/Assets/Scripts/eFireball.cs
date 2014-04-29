using UnityEngine;
using System.Collections;

public class eFireball : MonoBehaviour {

	private float speed = 1.75f;
	public int dmg = 15;

	void OnTriggerEnter2D (Collider2D other){ // if the fireball hits the player, you take damage
		if (other.gameObject.tag == "Player") {
			other.SendMessage("takeDmg", dmg);
			Destroy (gameObject);
		} 
		else if(other.transform.root.gameObject.tag == "Enemy" || other.gameObject.name == "wep" || other.gameObject.tag =="GameController"){ //all the exceptions, objects the fireball can hit without being destroyed

		}
		else { //should almost only be walls and objects
			Destroy (gameObject);
		}
	}

	void movedirection (Vector2 direction){
		rigidbody2D.velocity = (direction * speed); //moves the fireball in the direction of where the player was
	}
}
