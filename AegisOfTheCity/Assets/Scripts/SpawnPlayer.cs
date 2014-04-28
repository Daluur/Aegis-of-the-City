using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour {

	public GameObject thePlayer;

	// Use this for initialization
	void Start () {
		GameObject Player = Instantiate(thePlayer,transform.position,thePlayer.transform.rotation) as GameObject;
		Player.name = "Player"; //renames the player, for easier identification
		Player.BroadcastMessage ("loadVars"); //loads the score for the player, and the weapon for the wep
	}
}