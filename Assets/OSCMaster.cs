using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OSCsharp.Net;
using OSCsharp.Data;

public class OSCMaster : MonoBehaviour {

    public UDPTransmitter oscTransmitter;
    public OscMessage controllerOscMessage;
    private string footNameSpace = "/foot";
    private string timeNameSpace = "/time";
    private string distNameSpace = "/dist";

    // Use this for initialization
    void Start ()
    {
        oscTransmitter = new UDPTransmitter("127.0.0.1", 6666);
        oscTransmitter.Connect();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void sendFootStepOSC(string A)
    {
        controllerOscMessage = new OscMessage(footNameSpace);
        controllerOscMessage.Append(A);
        oscTransmitter.Send(controllerOscMessage);
    }

    public void sendTime(float time)
    {
        controllerOscMessage = new OscMessage(timeNameSpace);
        controllerOscMessage.Append(time);
        oscTransmitter.Send(controllerOscMessage);
    }

    public void sendDist(float dist)
    {
        controllerOscMessage = new OscMessage(distNameSpace);
        controllerOscMessage.Append(dist);
        oscTransmitter.Send(controllerOscMessage);
    }
}