using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	float xd=0.0f;
	float yd=0.0f;
	private Vector3 moveDirection;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		yd = 0;
		xd = 0;
		if (Input.GetKey("w")) {
			yd = 1.0f;
		}
		if (Input.GetKey("d")) {
			xd = 1.0f;
		}
		if (Input.GetKey("s")) {
			yd = -1.0f;
		}
		if (Input.GetKey("a")) {
			xd = -1.0f;
		}

		moveDirection = new Vector3(xd,yd,0).normalized;

		transform.position += moveDirection;
	}
}
