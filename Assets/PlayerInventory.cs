using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour {
	private int sticks = 0;
    private string tracker = "/10 sticks collected";
    public Text stickText;

	private bool water = false;
	private bool knife = false;
	private bool brotiene = false;

	// Use this for initialization
	void Start () {

        SticksText();
    }
	
	// Update is called once per frame
	void Update () {
        SticksText();
    }

	public void stickUp(){
        if(sticks < 7)
        {
            sticks += 1;
            SticksText();
        }
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

    void SticksText()
    {
        stickText.text = sticks.ToString() + tracker;
    }
}
