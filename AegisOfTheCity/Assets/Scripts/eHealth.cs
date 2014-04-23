using UnityEngine;
using System.Collections;

public class eHealth : MonoBehaviour {
	
	public int health = 3;
	
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
		print ("takes dmg");
		//Adjusts the size of the healthbar of the enemy, according to the amount of damage it has taken.
		GameObject.Find ("HealthbarHealth").SendMessage ("adjustHPBar", str);
	}

}
