using UnityEngine;
using System.Collections;

public class attack : MonoBehaviour {
	int timeofatk=18;



	// Use this for initialization
	void Start() {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {


	if (Input.GetKeyDown(KeyCode.Space)) {

			
			timeofatk = 18;
			if(timeofatk>0){
				renderer.enabled = true;
				transform.Rotate(0,0,20);

			}
		}
	if(timeofatk<0)
				renderer.enabled=false;
		
		timeofatk--;
	}
}
