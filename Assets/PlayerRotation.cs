using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
	//	private float AngleBetweenVector2 (Vector2 vec1, Vector2 vec2)
	//	{
	//		Vector2 diference = vec2 - vec1;
	//		float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
	//		return Vector2.Angle (Vector2.right, diference) * (sign);
	//	}

	public float speed = 2f;

	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		var y = transform.rotation.eulerAngles.y;

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.rotation = Quaternion.Euler (new Vector3 (0f, (y - speed  * Time.deltaTime + 360) % 360, 0f));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.rotation = Quaternion.Euler (new Vector3 (0f, (y + speed *Time.deltaTime) % 360, 0f));
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.rotation = Quaternion.Euler (new Vector3 (0f, (y - speed  * Time.deltaTime+ 360) % 360, 0f));
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.rotation = Quaternion.Euler (new Vector3 (0f, (y + speed * Time.deltaTime) % 360, 0f));
		}
	}
}