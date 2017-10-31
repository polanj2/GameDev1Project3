using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 0.2f;
	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("escape")) {//When a key is pressed down it see if it was the escape key if it was it will execute the code
			Application.Quit (); // Quits the game
		}

		var angle = transform.rotation.eulerAngles;
		float y = GameObject.Find("Camera").transform.rotation.eulerAngles.y;

    if (Input.GetKey (KeyCode.UpArrow)) {
      Vector3 position = this.transform.position;
			position.x += Mathf.Cos ((90 - y) * Mathf.PI / 180) * 0.2f;
			position.z += Mathf.Sin ((90 - y) * Mathf.PI / 180) * 0.2f;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
      Vector3 position = this.transform.position;
			position.x -= Mathf.Cos ((90 - y) * Mathf.PI / 180) * 0.2f;
			position.z -= Mathf.Sin ((90 - y) * Mathf.PI / 180) * 0.2f;
			this.transform.position = position;
		}

		if (Input.GetKey (KeyCode.W)) {
			Vector3 position = this.transform.position;
			position.x += Mathf.Cos ((90 - y) * Mathf.PI / 180) * 0.2f;
			position.z += Mathf.Sin ((90 - y) * Mathf.PI / 180) * 0.2f;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.S)) {
			Vector3 position = this.transform.position;
			position.x -= Mathf.Cos ((90 - y) * Mathf.PI / 180) * 0.2f;
			position.z -= Mathf.Sin ((90 - y) * Mathf.PI / 180) * 0.2f;
			this.transform.position = position;
		}
	}
}
