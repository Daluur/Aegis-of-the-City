using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public Vector2 speed = new Vector2(12, 12);
	private Vector2 movement;
	private float currentx = 0;
	private float currenty = 0;
	private Animator animator;
	private int currentAni = 0;
	
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update()
	{
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





		/*if (currentx != inputX) {
			currentx = inputX;
			if(inputX == 0 && inputY == 0){
				animator.SetTrigger("Idle");
			}
			else if(inputX > 0){
				animator.SetTrigger("Right");
			}
			else
			{
				animator.SetTrigger("Left");
			}
		}
		if (currenty != inputY) {
			currenty = inputY;
			if(inputY == 0 && inputX == 0){
				animator.SetTrigger("Idle");
			}
			else if(inputY > 0){
				animator.SetTrigger("Up");
			}
			else
			{
				animator.SetTrigger("Down");
			}
		}

		if (inputX == 0 && inputY == 0) {
			animator.SetTrigger("Idle");
			currentAni = 0;
		}
		else if (inputX > 0 && currentAni!= 1) {
			animator.SetTrigger ("Right");
			currentAni = 1;
		} 
		else if (inputX < 0 && currentAni!= 2) {
			animator.SetTrigger ("Left");
			currentAni = 2;
		} 
		else if (inputY > 0 && currentAni!= 3) {
			animator.SetTrigger ("Up");	
			currentAni = 3;
		} 
		else if (inputY < 0 && currentAni!= 4) {
			animator.SetTrigger ("Down");
			currentAni = 4;
		}*/






	}

	void FixedUpdate(){
		rigidbody2D.velocity = movement;
	}
	
	
}