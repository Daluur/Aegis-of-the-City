using UnityEngine;
using System.Collections;

public class EnemyDetect : MonoBehaviour {
	
	private bool detected;
	private Vector2 dir;
	private float dirX;
	private float dirY;
	private Vector2 player;
	private float speed = 0.5f;
	private Animator animator;
	
	void Start()
	{
		animator = GetComponent<Animator>();
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
		if (dirX != 0 || dirY != 0) {
			animator.SetBool ("moving", true);
		} 
		else {
			animator.SetBool("moving", false);
		}
		animator.SetFloat ("X", dirX);
		animator.SetFloat ("Y", dirY);
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
