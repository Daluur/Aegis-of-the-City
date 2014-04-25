using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private int score;
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("kills");
		guiText.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
