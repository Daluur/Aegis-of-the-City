using UnityEngine;
using System.Collections;

public class eAtk : MonoBehaviour {
	//creating placeholder gameobjects for the AOE fire spell graphics effect
	public GameObject hellfire;
	private GameObject hellclone;

	//when the trigger collides with the player the doAtk function will be called repeatedly every 2 seconds
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			InvokeRepeating("doAtk",0.1f,2);
		}
	}
	//when the trigger exits the players collide range the repeating function is cancelled
	void OnTriggerExit2D(Collider2D coll){
		CancelInvoke ();
	}

	//instantiates a new gameobject of the hellfire type at the same position as the enemy currently is
	void doAtk(){
		Instantiate (hellfire, transform.position, hellfire.transform.rotation);
		hellclone = GameObject.FindWithTag("aoe");
		hellclone.transform.parent = transform;
	}

}