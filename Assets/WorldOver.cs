using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldOver : MonoBehaviour {
	int time;
	int day;
	// Use this for initialization
	void Start () {
		time = 0;
		day = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void timeInc(){
		if (time < 50) {
			time++;
		}
	}
	void dayInc(){
		if (day < 7) {
			day++;
		}
	}
}
