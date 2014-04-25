using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour {

	public GameObject thePlayer;

	// Use this for initialization
	void Start () {
		GameObject Player = Instantiate(thePlayer,transform.position,thePlayer.transform.rotation) as GameObject;
		Player.name = "Player";
		Player.BroadcastMessage ("loadVars");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
