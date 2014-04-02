using UnityEngine;
using System.Collections;

public class Enemyhit : MonoBehaviour {




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {



		if(gameObject.renderer.bounds.Intersects(GameObject.Find("wep").renderer.bounds)&&GameObject.Find("wep").renderer.enabled==true){
			//This is where damage will happen!!!
			Destroy(gameObject);

		}
	
	}
}
