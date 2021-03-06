﻿using UnityEngine;
using System.Collections;

public class eHealth : MonoBehaviour {
	//the amount of health the enemy has
	public int health = 5;
	//the integer identifier for each enemy type (set in editor)
	public int eType;
	
	// Use this for initialization
	void Start () {
		//Initializes the healthbars for the enemies.
		gameObject.BroadcastMessage("maxHP", health);
	}
	
	// Update is called once per frame
	void Update () {
		//checks if the health variable hits 0 or below, and destroys the object if it does
		//instantiates a new dSound object and sends a message to it which will play a sound according to the enemy type
		if (health <= 0) {
			print ("enemy died");
			GameObject.Find("deathSound").SendMessage ("playSound", eType);
			GameObject.Find("Player").SendMessage ("killedEnemy");
			Destroy(gameObject);
		}
		
	}

	//the function to take damage
	//it receives a damage integer from the sender and subtracs that number from the health of the enemy
	void takeDmg (int str) {
		health -= str;
		//Adjusts the size of the healthbar of the enemy, according to the amount of damage it has taken.
		//GameObject.Find ("HealthbarHealth").SendMessage ("adjustHPBar", str);
	}


}
