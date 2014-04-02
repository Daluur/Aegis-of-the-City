using UnityEngine;
using System.Collections;

public class attack : MonoBehaviour {
	public static int timeofatk=18;
	Vector3 mouse_pos = new Vector3(0.0f,0.0f,0.0f);
	Vector3 object_pos = new Vector3 (0.0f, 0.0f, 0.0f);
	Vector3 playernewPos = new Vector3 (0.0f, 0.0f, 0.0f);
//	Vector3 wepstartPos = new Vector3 (0.0f, 0.0f, 0.0f);
	float angle = 0.0f;

	// Use this for initialization
	void Start() {
		renderer.enabled = false;

	}

	// Update is called once per frame
	void Update () {

	//	wepstartPos = transform.position;
		playernewPos = GameObject.Find ("player").transform.position;

		mouse_pos = Input.mousePosition;
		mouse_pos.z = -10.0f + 0.06835938f; //The distance between the camera and object
		object_pos = Camera.main.WorldToScreenPoint(playernewPos);
		mouse_pos.x = mouse_pos.x - object_pos.x;
		mouse_pos.y = mouse_pos.y - object_pos.y;
		angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;

	if (Input.GetMouseButtonDown(0)&&timeofatk<1) {
			timeofatk = 18;
			if(timeofatk>0){
				renderer.enabled = true;
				//Working rotation around player!!!
				transform.RotateAround(playernewPos,new Vector3(0.0f,0.0f,20.0f),angle-90);
			


			}
		}
if (timeofatk < 0) {


			renderer.enabled = false;
			transform.position = new Vector3(playernewPos.x,playernewPos.y+0.6f,playernewPos.z);
			transform.rotation =  Quaternion.identity;
			}
		
		timeofatk--;
	}
}
