using UnityEngine;
using System.Collections;

public class pHealth : MonoBehaviour {
	//the players health
	private int health = 95;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if the player dies, goto gameover screen
		if (health <= 0) {
			Application.LoadLevel(2);
				}
	
	}
	//the function is called by the weapons of the enemies
	//it takes an damage int in and subtracts that number from the total health
	void takeDmg (int str) {
		health -= str;
		if(health > 100){
			health = 100;
		}
		print (health);
	}
}
