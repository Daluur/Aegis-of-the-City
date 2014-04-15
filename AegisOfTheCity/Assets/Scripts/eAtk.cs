using UnityEngine;
using System.Collections;

public class eAtk : MonoBehaviour {

	public GameObject hellfire;
	private GameObject hellclone;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			InvokeRepeating("doAtk",0.1f,2);
				}
	}

	void OnTriggerExit2D(Collider2D coll){
		CancelInvoke ();
		}

	void doAtk(){
		Instantiate (hellfire, transform.position, hellfire.transform.rotation);
		hellclone = GameObject.FindWithTag("aoe");
		hellclone.transform.parent = transform;
	}

	void dontAtk(){
		renderer.enabled = false;
	}
}