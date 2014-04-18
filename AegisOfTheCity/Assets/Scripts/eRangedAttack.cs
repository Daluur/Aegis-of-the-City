using UnityEngine;
using System.Collections;

public class eRangedAttack : MonoBehaviour {

	public GameObject Fireball;
	private Vector2 playerLoc;
	private bool playerIsInRange = false;
	private Vector2 dir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerIsInRange) {
			playerLoc = GameObject.FindWithTag ("Player").transform.position;
			dir.x = (playerLoc.x - transform.position.x);
			dir.y = (playerLoc.y - transform.position.y);
		}
	}

	void playerInRange(Vector2 playerLocation){
		playerIsInRange = true;
		playerLoc = playerLocation;
		InvokeRepeating ("RangedAttack", 0.1f, 2.0f);
	}

	void playerNotInRange(){
		playerIsInRange = false;
		CancelInvoke ();
	}

	void RangedAttack(){

		GameObject newFireball = Instantiate(Fireball,transform.position,Fireball.transform.rotation) as GameObject;
		newFireball.SendMessage ("movedirection", dir.normalized);
		gameObject.SendMessage ("moves", dir.normalized);
	}
}
