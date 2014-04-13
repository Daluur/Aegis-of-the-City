using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public int score = 23243;
	// Use this for initialization
	void Start () {
		guiText.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
