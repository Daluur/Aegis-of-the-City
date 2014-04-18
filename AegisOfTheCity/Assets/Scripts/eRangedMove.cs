using UnityEngine;
using System.Collections;

public class eRangedMove : MonoBehaviour {

	private float speed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void moves(Vector2 direction){
		rigidbody2D.velocity = (-direction * speed);
	}

}
