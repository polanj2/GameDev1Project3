using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
	private int sticks = 0;
	private bool water = false;
	private bool knife = false;
	private bool brotiene = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void stickUp(){
		sticks += 1;
	}
	public void knifeGet(){
		knife = true;
	}
	public void broGet(){
		brotiene = true;
	}
	public void waterGet(){
		water = true;
	}
	public bool hasWater(){
		return (water);
	}
	public bool hasKnife(){
		return (knife);
	}
	public bool hasBro(){
		return (brotiene);
	}
}
