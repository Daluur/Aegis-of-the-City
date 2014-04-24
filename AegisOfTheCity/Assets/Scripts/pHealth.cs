using UnityEngine;
using System.Collections;

public class pHealth : MonoBehaviour {
	//the players health
	private int health = 100;
	private int Kills = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if the player dies, goto gameover screen
		if (health <= 0) {
			Application.LoadLevel("Lose");
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

	void killedEnemy(){
		Kills++;
		print (Kills);
	}

	void saveVars(){
		PlayerPrefs.SetInt ("kills", Kills);
		PlayerPrefs.Save ();
	}

	void loadVars(){
		Kills = PlayerPrefs.GetInt ("kills");
	}

}