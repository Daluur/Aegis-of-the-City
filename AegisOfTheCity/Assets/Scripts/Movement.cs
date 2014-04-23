using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//variables to hold the speed, the movement and the animation
	public Vector2 speed = new Vector2(12, 12);
	private Vector2 movement;
	private Animator animator;
	
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		//gets input from the keyboard, WASD or arrow keys
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		animator.SetFloat ("speedX", inputX);
		animator.SetFloat ("speedY", inputY);

		// 3 - Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);


		if (inputX != 0 || inputY != 0) {
			animator.SetBool ("moving", true);
		} 
		else {
			animator.SetBool("moving", false);
		}
		



	}
	//sets rigibody velocity to the movement variables values
	void FixedUpdate(){
		rigidbody2D.velocity = movement;
	}
	
	
}