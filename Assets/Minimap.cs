using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Change the width of the viewport each time space key is pressed

public class Minimap : MonoBehaviour
{
	void Start ()
	{
		
	}

	void Update ()
	{
		GameObject.Find ("Mini Map").GetComponent<Camera> ().pixelRect = new Rect (Screen.width - 100, Screen.height - 100, 100, 100);
	}
}
