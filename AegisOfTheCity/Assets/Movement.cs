using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	float x=0.0f;
	float y=0.0f;
	float z=0.0f;
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey("w")) {
						y += 1.0f;
				}
	if (Input.GetKey("d")) {
			x += 1.0f;
		}
		if (Input.GetKey("s")) {
			y -= 1.0f;
		}
		if (Input.GetKey("a")) {
			x -= 1.0f;
		}
		transform.position = new Vector2(x,y);
	}
}
