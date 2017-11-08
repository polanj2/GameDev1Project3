using UnityEngine;
using System.Collections;

public class TileCounter : MonoBehaviour
{
	float startX;
	float startZ;


	void Start ()
	{
		var pos = GameObject.Find ("Main Camera").transform.position;
		startX = pos.x;
		startZ = pos.z;
		print (startX + " " + startZ);
	}

	void Update ()
	{
		
	}
}
