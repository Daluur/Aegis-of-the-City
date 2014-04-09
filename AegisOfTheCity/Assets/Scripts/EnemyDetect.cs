using UnityEngine;
using System.Collections;

public class EnemyDetect : MonoBehaviour {
	
	private bool detected;
	private Vector2 dir;
	private float dirX;
	private float dirY;
	private Vector2 player;
	private float speed = 0.5f;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (detected == true) {
			player = GameObject.FindWithTag ("Player").transform.position;
			dirX = (player.x - transform.position.x);
			dirY = (player.y - transform.position.y);
			dir = new Vector2 (dirX,dirY);
			
			rigidbody2D.velocity = (dir * speed);
		} else {
			rigidbody2D.Sleep();
		}
		
	}
	
	void FixedUpdate(){
		//rigidbody2D.velocity = movement;
	}
	
	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			detected = true;

		}
	}

	void stopMove(){
		detected = false;
		}
}
