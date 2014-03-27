using UnityEngine;
using System.Collections;

public class attack : MonoBehaviour {
	GameObject player = new GameObject();

	// Use this for initialization
	void Start() {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Space)) {

			transform.position = player.transform.position;
			renderer.enabled = true;
		
		
		}
	}
}
