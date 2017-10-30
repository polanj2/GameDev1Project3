using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendData : MonoBehaviour {

    public OSCMaster master;

	// Use this for initialization
	void Start () {
        GameObject myWorld = GameObject.Find("World");
        master = (OSCMaster)myWorld.GetComponent<OSCMaster>();
    }
	
	// Update is called once per frame
	void Update () {
        // Demo data send of distance between self and world center
        master.sendDist(Vector3.Distance(master.gameObject.transform.position, gameObject.transform.position));
	}
}
