using UnityEngine;
using System.Collections;

public class EnemyDetect : MonoBehaviour {
	
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void FixedUpdate(){
		//rigidbody2D.velocity = movement;
	}

	//When trigger collides with player, the follow function is called using sendmessage
	//A sound clip is also triggered
	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			audio.Play ();
			transform.root.gameObject.SendMessage("move");
			
		}
	}
	
	
}
