using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
<<<<<<< HEAD

	float x=0.0f;
	float y=0.0f;
=======
	float xd=0.0f;
	float yd=0.0f;
	private Vector3 moveDirection;
>>>>>>> bd86c247f71b02e8bec10993081a6a5206487b8e
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
