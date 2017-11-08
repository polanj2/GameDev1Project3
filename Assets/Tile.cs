using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
	public string Type;
	//Detect collisions between the GameObjects with Colliders attached
	void OnTriggerEnter (Collider collider)
	{
		if (Type == "G") {
			(GameObject.Find ("World")).GetComponent<WorldOver> ().timeInc ();
			Debug.Log ((GameObject.Find ("World")).GetComponent<WorldOver> ().timeGet ());
		}
		if (Type == "R") {
			Debug.Log ("YOU WIN");
		}
	}
}