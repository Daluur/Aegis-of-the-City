using UnityEngine;
using System.Collections;

public class eRangedAttack : MonoBehaviour {

	public GameObject Fireball;
	private Vector2 playerLoc;
	private bool playerIsInRange = false;
	private Vector2 dir;

	// Update is called once per frame
	void Update () {
		if (playerIsInRange) { //if the player is in range, it will constantly update the players position, in accordance to the enemy
			playerLoc = GameObject.FindWithTag ("Player").transform.position;
			dir.x = (playerLoc.x - transform.position.x);
			dir.y = (playerLoc.y - transform.position.y);
		}
	}

	void playerInRange(Vector2 playerLocation){ //player has entered the range
		playerIsInRange = true; 
		playerLoc = playerLocation;
		InvokeRepeating ("RangedAttack", 0.1f, 2.0f); //invokes the call for creating fireballs
	}

	void playerNotInRange(){ //when the player is no longer in range
		playerIsInRange = false;
		CancelInvoke (); //stops the fireball creation
		rigidbody2D.Sleep(); //makes the enemy "sleep" he does not move
	}

	void RangedAttack(){
		//calls the appropriate sound from the dSound object
		GameObject.Find("deathSound").SendMessage ("playSound", 5);
		GameObject newFireball = Instantiate(Fireball,transform.position,Fireball.transform.rotation) as GameObject; //creates the fireball
		newFireball.SendMessage ("movedirection", dir.normalized); //tells the fireball its direction
		gameObject.SendMessage ("moves", dir.normalized); //moves the enemy away from the player
	}
}
