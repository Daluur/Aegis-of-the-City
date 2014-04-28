using UnityEngine;
using System.Collections;

public class deathSounds : MonoBehaviour {

	//public audiosource holders where different sounds can be added
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;
	public AudioSource audio4;
	public AudioSource audio5;

	//the incoming function-call receives an int which determines which death sound to be played
	void playSound(int play){
		if (play == 1)
		audio1.Play ();
		if (play == 2)
		audio2.Play ();
		if (play == 3)
		audio3.Play ();
		if (play == 4)
		audio4.Play ();
		if (play == 5)
		audio5.Play ();
	}
}