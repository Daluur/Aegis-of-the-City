﻿using UnityEngine;
using System.Collections;

public class eHealth : MonoBehaviour {
	
	private int health = 3;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (health <= 0) {
			print ("enemy died");
			Destroy(gameObject);
		}
		
	}
	
	void takeDmg (int str) {
		health -= str;
	}
}