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
	
	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			transform.root.gameObject.SendMessage("move");
			
		}
	}
	
	
}
