using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //private float varX = 0;
    //private float varY = 0;
    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("escape"))
        {//When a key is pressed down it see if it was the escape key if it was it will execute the code
            Application.Quit(); // Quits the game
        }

        float xAxisValue = Input.GetAxis("Horizontal") * speed;
        float zAxisValue = Input.GetAxis("Vertical") * speed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
    }
}
