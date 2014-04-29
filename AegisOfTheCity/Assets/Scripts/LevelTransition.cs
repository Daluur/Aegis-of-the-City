using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {

	//If the enemy has reached the transition spot on the map, it loads a new level.
	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.name == "Player") {
			GameObject.Find("Player").SendMessage("saveVars"); //makes the player save his variables, the amount of kills
			int currlvl = Application.loadedLevel; //defines the current level
			Application.LoadLevel(++currlvl); //when the current level is defined it is easy to load the next
		}
	}
}
