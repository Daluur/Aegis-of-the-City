using UnityEngine;
using System.Collections;

public class eMove : MonoBehaviour {

	//various variables created to control detection, direction, a container for the player, the animator and the speed
	private bool detected;
	private Vector2 dir;
	private float dirX;
	private float dirY;
	private Vector2 player;
	private float speed = 0.5f;
	private Animator animator;
	
	// Use this for initialization
	void Start () {
	//fills the container with the attached animator component
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		//if the detected var is true, find the position of the player object
		//set the X and Y directions to the direction towards the player by subtracting the players position with the enemies position
		//sets the velocity of the enemies rigidbody to the set direction with the set speed
		if (detected == true) {
			player = GameObject.FindWithTag ("Player").transform.position;
			dirX = (player.x - transform.position.x);
			dirY = (player.y - transform.position.y);
			dir = new Vector2 (dirX,dirY);
			//Adds more speed the longer the enemy Squisher follows the player.
			if(gameObject.name == "Squisher")
			speed +=0.010f;
			rigidbody2D.velocity = (dir * speed);
		} else {
			//if the player isnt detected the rigidbody is motionless in sleep mode
			rigidbody2D.Sleep();
			}
		//starts the animation if the direction is anything other than a standstill 0,0
		//and otherwise its set to a standstill "animation"
		if(dirX != 0 || dirY != 0){
			animator.SetBool ("moving",true);
		}
		else {
			animator.SetBool ("moving",false);
		}

		animator.SetFloat ("X",dirX);
		animator.SetFloat ("Y",dirY);
	
	}

	//2 functions which sets the detection of the player to either true or false
	//these are called by the detection script
	void stopMove(){
		detected = false;
	}
	
	void move(){
		detected = true;
	}
}
