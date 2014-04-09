using UnityEngine;
using System.Collections;

public class weapon_pickup : MonoBehaviour {

	public Sprite[] Weapons;
	public SpriteRenderer renderer;
	private int nextWep;


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
			coll.SendMessage("weaponUpgrade", Weapons[nextWep]);
			Debug.Log ("works :)");
			Destroy(gameObject);
		}
	}
}
