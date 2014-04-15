using UnityEngine;
using System.Collections;

public class Squisher : MonoBehaviour {

	public int squisherDMG = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "Player")
						InvokeRepeating ("squishDMG", 0.1f, 0.5f);
						

	}
	void squishDMG(){
		GameObject.FindWithTag ("Player").SendMessage ("takeDmg", squisherDMG);

	}
	void OnTriggerExit2D(Collider2D coll){
		CancelInvoke ();
	}
}

