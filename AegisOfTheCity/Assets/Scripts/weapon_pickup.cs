using UnityEngine;
using System.Collections;

public class weapon_pickup : MonoBehaviour {

	public Sprite[] Weapons;
	public SpriteRenderer renderer;
	private int nextWep;
	//Etype contains the identifier for which sound to send to the dSound object
	public int eType;


	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("wep") > 0) { //makes sure it shows the correct weapon
			nextWep = PlayerPrefs.GetInt("wep")-2; // -2 because, damage starts at 2, whereas the weapon array starts at 0
		}
		else{
			nextWep = 0;
		}
		renderer = transform.GetComponent<SpriteRenderer>();
		renderer.sprite = (Sprite)Weapons [nextWep];
	}
	
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.name == "wep") {
			//sends the sound identifier to the dSound object
			GameObject.Find("deathSound").SendMessage ("playSound", eType);
			coll.SendMessage("weaponUpgrade", Weapons[nextWep]); //upgrades the players weapon
			Destroy(gameObject);
		}
	}
}
