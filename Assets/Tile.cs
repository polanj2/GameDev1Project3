using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
	public string Type;
	public float fadeSpeed = 0.5f;
	public Color fadeColor = Color.black;
	//Detect collisions between the GameObjects with Colliders attached
	void OnTriggerEnter (Collider collider)
	{
		if (Type == "G") {
			(GameObject.Find ("World")).GetComponent<WorldOver> ().timeInc ();
			Debug.Log ((GameObject.Find ("World")).GetComponent<WorldOver> ().timeGet ());
		}
		if (Type == "R") {
			Initiate.Fade ("WinScreen", fadeColor, fadeSpeed);
		}
	}
}