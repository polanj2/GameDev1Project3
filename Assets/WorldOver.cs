using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldOver : MonoBehaviour
{
	int time;
	int day;
	//private int scene = 2;

	public float fadeSpeed = 0.5f;
	public string sceneName;
	public Color fadeColor = Color.black;

	// Use this for initialization
	void Start ()
	{
		time = 0;
		day = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
//		time++;
	}

	public void timeInc ()
	{
		if (time < 50) {
			time++;
		}
	}

	public void dayInc ()
	{
		if (day < 7) {
			day++;
			time = 0;
			Initiate.Fade (sceneName, fadeColor, fadeSpeed);
		} else {
			Initiate.Fade ("GameOverSlate", fadeColor, fadeSpeed);
			//SceneManager.LoadScene(scene);
		}
	}

	public int timeGet ()
	{
		return time;
	}
}
