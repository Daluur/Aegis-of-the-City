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
		renderer = transform.GetComponent<SpriteRenderer>();
		renderer.sprite = (Sprite)Weapons [nextWep];
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.name == "wep") {
			//sends the sound identifier to the dSound object
			GameObject.Find("deathSound").SendMessage ("playSound", eType);
			coll.SendMessage("weaponUpgrade", Weapons[nextWep]);
			Debug.Log ("works :)");
			Destroy(gameObject);
		}
	}
}
