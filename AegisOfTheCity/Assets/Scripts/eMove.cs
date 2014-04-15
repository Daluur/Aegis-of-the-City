using UnityEngine;
using System.Collections;

public class eMove : MonoBehaviour {

	private bool detected;
	private Vector2 dir;
	private float dirX;
	private float dirY;
	private Vector2 player;
	private float speed = 0.5f;
	private Animator animator;
	
	// Use this for initialization
	void Start () {
	
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

		if (detected == true) {
			player = GameObject.FindWithTag ("Player").transform.position;
			dirX = (player.x - transform.position.x);
			dirY = (player.y - transform.position.y);
			dir = new Vector2 (dirX,dirY);
			speed +=0.005f;
			rigidbody2D.velocity = (dir * speed);
		} else {
			rigidbody2D.Sleep();
			}

		if(dirX != 0 || dirY != 0){
			animator.SetBool ("moving",true);
		}
		else {
			animator.SetBool ("moving",false);
		}

		animator.SetFloat ("X",dirX);
		animator.SetFloat ("Y",dirY);
	
	}

	void stopMove(){
		detected = false;
	}
	
	void move(){
		detected = true;
	}
}
