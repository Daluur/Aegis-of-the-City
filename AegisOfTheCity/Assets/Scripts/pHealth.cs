﻿using UnityEngine;
using System.Collections;

public class pHealth : MonoBehaviour {

	private int health = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (health <= 0) {
			print ("you died");
				}
	
	}

	void takeDmg (int str) {
		health -= str;
	}
}