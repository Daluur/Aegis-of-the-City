﻿using UnityEngine;
using System.Collections;

public class EnemyRetreat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			transform.root.gameObject.SendMessage ("stopMove");
		}

	}
}
