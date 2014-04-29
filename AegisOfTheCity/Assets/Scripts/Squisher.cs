using UnityEngine;
using System.Collections;

public class Squisher : MonoBehaviour {

	/// <summary>
	/// The Damage of the Squisher minion
	/// </summary>
	public int squisherDMG = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/// <summary>
	/// Checks if the squisher collides with the player, if there is collision, the player will repeatedly take damage every 0.5s.
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "Player"){
			InvokeRepeating ("squishDMG", 0.1f, 0.5f);
		}			
	}
	/// <summary>
	/// This function sends a message to the player, with the damage the player has received.
	/// </summary>
	void squishDMG(){
		GameObject.FindWithTag ("Player").SendMessage ("takeDmg", squisherDMG);

	}
	/// <summary>
	/// When the squisher no longer collides with the player, it stops the damage to the player.
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnTriggerExit2D(Collider2D coll){
		CancelInvoke ();
	}
}

