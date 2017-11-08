using UnityEngine;
using System.Collections;

public class InitMap : MonoBehaviour
{
	public GameObject tile;
	private GameObject temptile;

	void Start ()
	{
		temptile = GameObject.Instantiate (tile, new Vector3 (0, 0, -10), new Quaternion ());
		temptile.name = "StartTile";
	}

	void Update ()
	{

	}
}
