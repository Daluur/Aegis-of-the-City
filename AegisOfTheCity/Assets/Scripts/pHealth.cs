using UnityEngine;
using System.Collections;

public class pHealth : MonoBehaviour {

	private int health = 95;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (health <= 0) {
			Application.LoadLevel(2);
				}
	
	}

	void takeDmg (int str) {
		health -= str;
		if(health > 100){
			health = 100;
		}
		print (health);
	}
}
