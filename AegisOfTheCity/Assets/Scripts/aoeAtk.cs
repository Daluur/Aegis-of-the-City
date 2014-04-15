using UnityEngine;
using System.Collections;

public class aoeAtk : MonoBehaviour {

	public int eDmg = 2;
	
	
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.SendMessage("takeDmg",eDmg);
		} 
	}
}
