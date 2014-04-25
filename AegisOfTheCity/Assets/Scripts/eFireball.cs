using UnityEngine;
using System.Collections;

public class eFireball : MonoBehaviour {

	private float speed = 1.75f;
	public int dmg = 15;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			other.SendMessage("takeDmg", dmg);
			Destroy (gameObject);
		} 
		else if(other.transform.root.gameObject.tag == "Enemy" || other.gameObject.name == "wep" || other.gameObject.tag =="GameController"){

		}
		else {
			Destroy (gameObject);
		}
	}

	void movedirection (Vector2 direction){
		rigidbody2D.velocity = (direction * speed);
	}
}
