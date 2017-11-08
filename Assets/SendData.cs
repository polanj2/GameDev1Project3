using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendData : MonoBehaviour
{

    public OSCMaster master;
    public GameObject monster;
    private GameObject myWorld;
    private float timer;
    public float footstepTime;

    // Use this for initialization
    void Start()
    {
        myWorld = GameObject.Find("World");
        master = (OSCMaster)myWorld.GetComponent<OSCMaster>();
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Demo data send of distance between self and world center
        // master.sendDist(Vector3.Distance(master.gameObject.transform.position, gameObject.transform.position));

        // Now ideally we would calculate L/R mixing, but this is actually hella math and I'm not gonna get into that right now.
        // I tried for like a half hour to put my brain through it and I was just too dumb.

        // Just send distance from the monster to the player.
        master.sendDist(Vector3.Distance(monster.transform.position, gameObject.transform.position));

        // Check if the player should be moving.
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1 || Mathf.Abs(Input.GetAxis("Vertical")) > 0.1)
        {
            // Check if enough time has elapsed since the last footstep.
            if (Time.time - timer > footstepTime)
            {
                // If there are multiple ground surfaces, the argument here is how to change the sound.
                master.sendFootStepOSC("Standard");
                // Then reset footstep time so it doesn't spam the hell out of ya.
                timer = Time.time;
            }
        }

        // Take the time from the world and send it in.
        master.sendTime(myWorld.GetComponent<WorldOver>().timeGet());
    }
}