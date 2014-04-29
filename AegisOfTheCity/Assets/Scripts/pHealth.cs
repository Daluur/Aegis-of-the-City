using UnityEngine;
using System.Collections;

public class pHealth : MonoBehaviour {

	private int health = 100;
	private int Kills = 0; //used as score

	// Update is called once per frame
	void Update () {
		//if the player dies, goto gameover screen
		if (health <= 0) {
			saveVars();
			Application.LoadLevel("Lose");
		}
	}
	//the function is called by the weapons of the enemies
	//it takes an damage int in and subtracts that number from the total health
	void takeDmg (int str) {
		health -= str;
		if(health > 100){ //makes you unable to get more health than 100, so if you get a healtpot at max health, it will not heal
			health = 100;
		}
	}

	void killedEnemy(){ //called whenever a monster dies
		Kills++;
	}

	void saveVars(){
		PlayerPrefs.SetInt ("kills", Kills);
		PlayerPrefs.Save (); // saves the score
	}

	void loadVars(){
		Kills = PlayerPrefs.GetInt ("kills"); //loads the score
	}

}