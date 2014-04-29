using UnityEngine;
using System.Collections;

public class eRangedMove : MonoBehaviour {

	private float speed = 2;

	void moves(Vector2 direction){
		rigidbody2D.velocity = (-direction * speed); //moves the enemy
	}

}
