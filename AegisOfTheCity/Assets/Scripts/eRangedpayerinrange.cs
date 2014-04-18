using UnityEngine;
using System.Collections;

public class eRangedpayerinrange : MonoBehaviour {

	private Vector2 plPosition;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			plPosition.x = other.transform.position.x;
			plPosition.y = other.transform.position.y;
			transform.root.gameObject.SendMessage("playerInRange", plPosition);
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			transform.root.gameObject.SendMessage("playerNotInRange");
		}
	}
}
