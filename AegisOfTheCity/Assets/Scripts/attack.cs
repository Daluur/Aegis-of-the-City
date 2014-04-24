using UnityEngine;
using System.Collections;

public class attack : MonoBehaviour {

	/// <summary>
	/// The Time the attack is active.
	/// </summary>
	public static int timeofatk=18;
	/// <summary>
	/// The poosition of the mouse.
	/// </summary>
	Vector3 mouse_pos = new Vector3(0.0f,0.0f,0.0f);
	/// <summary>
	/// The position of the object.
	/// </summary>
	Vector3 object_pos = new Vector3 (0.0f, 0.0f, 0.0f);
	/// <summary>
	/// The players current position.
	/// </summary>
	Vector3 playerPos = new Vector3 (0.0f, 0.0f, 0.0f);
	/// <summary>
	/// The angle used so the weapon points towards the mouse.
	/// </summary>
	float angle = 0.0f;
	/// <summary>
	/// The dammage.
	/// </summary>
	int dmg = 2;
	/// <summary>
	/// The weapon.
	/// </summary>
	public Sprite[] Weapon;
	public SpriteRenderer renderer;

	// Use this for initialization
	void Start() {

		//Sets the weapon the player has equipped, to the weapon the player needs to attack with
		renderer = transform.GetComponent<SpriteRenderer>();
		renderer.sprite = (Sprite)Weapon[0];
		//Sets the renderer to false, so we are not able to see the weapon
		renderer.enabled = false;
	}

	// Update is called once per frame
	void Update () {

		//The position of the player in the world environment
		playerPos = GameObject.Find ("Player").transform.position;

		//The position of the mouse in the screen environment
		mouse_pos = Input.mousePosition;
		//sets the objects position to be equal to the players position in the screen environment
		object_pos = Camera.main.WorldToScreenPoint(playerPos);
		//Calculates the distance the object is from the mouse, which is then used to calculate the angle of which the object needs to be turned,
		//So that it will point at the mouse, when the mouse is clicked
		mouse_pos.x = mouse_pos.x - object_pos.x;
		mouse_pos.y = mouse_pos.y - object_pos.y;
		angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;


		//Checks if a player has clicked the mouse button, and that there is no attack ongoing
	if (Input.GetMouseButtonDown(0)&&timeofatk<1) {
			//The length of the attack, which is 3/4 of one second in this case
			timeofatk = 18;
			//When the attack is ongoing, the renderer is enabled, which allows us to see the weapon and a swing soundclip is played.
			if(timeofatk>0){
				renderer.enabled = true;
				transform.audio.Play();
				//Rotation around the player, so that the weapon will point at the direction of the mouse
				transform.RotateAround(playerPos,new Vector3(0.0f,0.0f,20.0f),angle-45);
			}

		}
//This sets the renderer to false, when the attack has finished, and resets the position of the weapon, to the start position
if (timeofatk < 0) {
			renderer.enabled = false;
			transform.position = new Vector3(playerPos.x,playerPos.y,playerPos.z);
			transform.rotation =  Quaternion.identity;
			}
		
		//To stop the attack
		timeofatk--;

		//This makes sure that timeofatk, can't go a whole loop, and start from the positive values
		if (timeofatk < -10000)
						timeofatk = -1;
	}
	/// <summary>
	/// Checks if ongoing attack has collision with an enemy, if it does it sends a damage message to the enemy, plays a soundclip, and adjusts the health bar.
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Enemy" && gameObject.renderer.enabled == true) {
			coll.gameObject.SendMessage ("takeDmg",dmg);
			coll.gameObject.transform.FindChild("HealthbarHealth").SendMessage("adjustHPBar",dmg);
			transform.parent.audio.Play();
				}
	}
	/// <summary>
	/// Upgrades the damage of the player when a new weapon is picked up.
	/// </summary>
	/// <param name="newWep">New wep.</param>
	void weaponUpgrade(Sprite newWep){
		dmg++;
		renderer.sprite = (Sprite)newWep;
		PlayerPrefs.SetInt ("wep", 3);
		PlayerPrefs.Save ();
	}

	void loadVars(){
		print (PlayerPrefs.GetInt("wep"));
	}

}
