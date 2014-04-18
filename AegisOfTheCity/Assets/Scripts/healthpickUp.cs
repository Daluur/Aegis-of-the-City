using UnityEngine;
using System.Collections;

public class healthpickUp : MonoBehaviour {

	public int healAmount = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "Player") {
			coll.SendMessage("takeDmg", -healAmount);
			Destroy(gameObject);
		}
	}

}
