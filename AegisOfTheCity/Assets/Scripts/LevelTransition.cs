using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	




	}
		   void OnTriggerEnter2D (Collider2D coll){
			if (coll.gameObject.name == "Player") {
				if(Application.loadedLevel == 1)
					Application.LoadLevel(3);
			
			
			
			
			}

		}
}
