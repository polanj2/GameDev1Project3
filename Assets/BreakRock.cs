using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakRock : MonoBehaviour
{
    public Animator rock;

	// Use this for initialization
	void Start ()
    {
		rock.Play("rubble");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            crumble();
            Destroy(gameObject, .5f);
        }
    }

    void crumble()
    {
        rock.Play("New State");
    }
}
