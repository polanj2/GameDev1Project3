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
	public void timeInc(){
		if (time < 50) {
			time++;
		}
	}
	public void dayInc(){
		if (day < 7) {
			day++;
			time = 0;
		}
	}
	public int timeGet(){
		return time;
	}
}
