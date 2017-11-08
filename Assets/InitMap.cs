using UnityEngine;
using System.Collections;

public class InitMap : MonoBehaviour
{
	GameObject[,] tiles;
	public GameObject tile1;
	public GameObject tile2;
	public GameObject tile3;
	public GameObject Stick;
	public GameObject brotiene;
	public GameObject Knife;
	private GameObject tempTile;

	void Start ()
	{
		tiles = new GameObject[100,100];
		for (int a = 0; a < 100; a++)
		{
			for (int b = 0; b < 100; b++)
			{
				tempTile = GameObject.Instantiate(tile1, gameObject.transform);
				tempTile.transform.localPosition = new Vector3(b * 10 / 100 - 5 + tempTile.transform.localScale.x * 5, 0, a * 10 / 100 - 5 + tempTile.transform.localScale.y * 5);
				tempTile.name = a.ToString() + " - " + b.ToString();
				tiles[a, b] = tempTile;
			}
		}
	}

	void Update ()
	{

	}
}
