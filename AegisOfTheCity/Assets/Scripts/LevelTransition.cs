﻿using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	




	}
			//If the enemy has reached the transition spot on the map, it loads a new level.
	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.name == "Player") {
			GameObject.Find("Player").SendMessage("saveVars");
			int currlvl = Application.loadedLevel;
			Application.LoadLevel(++currlvl);
		}
	}
}
