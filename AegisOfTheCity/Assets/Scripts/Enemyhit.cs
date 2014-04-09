using UnityEngine;
using System.Collections;

public class Enemyhit : MonoBehaviour {




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {



		if(gameObject.renderer.bounds.Intersects(GameObject.Find("wep").renderer.bounds)&&GameObject.Find("wep").renderer.enabled==true){
			//This is where player damage to enemy will happen!!!
			Destroy(gameObject);

		}

		if (gameObject.renderer.bounds.Intersects (GameObject.Find ("Player").renderer.bounds))
			//this is where enemy hits player actions will happen
			Debug.Log ("Player has been hit and is injured!!!!!");
	
	}
}
