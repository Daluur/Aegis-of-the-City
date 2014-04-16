using UnityEngine;
using System.Collections;

public class eHealthBar : MonoBehaviour {


	// This script will make a GUITexture follow a transform.
	
	public Transform target;


	void Update ()
		
	{

		
		var wantedPos = Camera.main.WorldToViewportPoint (target.position);
		
		transform.position = wantedPos;

		
	}
	void adjustHPBar(int dmg){
		float scaleofHealthbar = 0.0038f;
			gameObject.transform.localScale = new Vector3 (-(dmg*scaleofHealthbar), 0f, 0f);
		}


}
