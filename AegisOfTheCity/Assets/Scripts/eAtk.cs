using UnityEngine;
using System.Collections;

public class eAtk : MonoBehaviour {

	public int timeofatk = 0;
	private float atkRt = 4;

	// Use this for initialization
	void Start () {
		renderer.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {

		if(timeofatk>0){
			InvokeRepeating("doAtk", 0.01f, atkRt);
		}

		if (timeofatk < 0) {
			dontAtk ();
		}

		if (renderer.enabled == true) {
			timeofatk--;
				}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			timeofatk = 18;
		}
		if (coll.gameObject.tag == "Player" && gameObject.renderer.enabled == true) {
			coll.gameObject.SendMessage ("takeDmg",2);
	}
	}

	void doAtk(){
		renderer.enabled = true;
	}

	void dontAtk(){
		renderer.enabled = false;
	}
}