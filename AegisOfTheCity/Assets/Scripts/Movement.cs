using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public Vector2 speed = new Vector2(12, 12);
	private Vector2 movement;
	
	void Update()
	{
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 3 - Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
	}

	void FixedUpdate(){
		rigidbody2D.velocity = movement;
	}
	
	
}