using UnityEngine;
using System.Collections;

public class InitMap : MonoBehaviour
{
	GameObject[,] tiles;
	public GameObject tile1;
	public GameObject tile2;
	public GameObject tile3;
	public GameObject tile4;
	public GameObject Stick;
	public GameObject brotiene;
	public GameObject tree;
	private GameObject tempTree;
	private GameObject tempTile;
	GameObject[] trees;


	void Start ()
	{
		tiles = new GameObject[100,100];
		for (int a = 0; a < 100; a++){
			for (int b = 0; b < 100; b++){
				if (a < 38 && b < 39) {
					tempTile = GameObject.Instantiate (tile2, gameObject.transform);
					tempTile.name = a.ToString() + " b- " + b.ToString();
				} else if (a < 52 && a > 48 && b < 52 && b > 48) {
					tempTile = GameObject.Instantiate (tile3, gameObject.transform);
					tempTile.name = a.ToString() + " c- " + b.ToString();
				} else if (b > 54 && b < 57 && a <20) {
					tempTile = GameObject.Instantiate (tile4, gameObject.transform);
					tempTile.name = a.ToString() + " c- " + b.ToString();
				} else {
					tempTile = GameObject.Instantiate (tile1, gameObject.transform);
					tempTile.name = a.ToString() + " a- " + b.ToString();
				}
				tempTile.transform.localPosition = new Vector3(b * 5, 0, a * 5);
				tiles[a, b] = tempTile; 
			}
		}
		trees = new GameObject[100];
		for (int a = 0; a < 100; a++){
			tempTree = GameObject.Instantiate (tree, gameObject.transform);
			tempTree.name = a.ToString() + " - ";
			tempTree.transform.localPosition = new Vector3(a * 5, 0, 0);
			trees[a] = tempTile;
		}
		for (int a = 0; a < 100; a++){
			tempTree = GameObject.Instantiate (tree, gameObject.transform);
			tempTree.name = a.ToString() + " - ";
			tempTree.transform.localPosition = new Vector3(a * 5, 0, 500);
			trees[a] = tempTile;
		}
		for (int a = 0; a < 100; a++){
			tempTree = GameObject.Instantiate (tree, gameObject.transform);
			tempTree.name = a.ToString() + " - ";
			tempTree.transform.localPosition = new Vector3(500, 0, 5 * a);
			trees[a] = tempTile;
		}
		for (int a = 0; a < 100; a++){
			tempTree = GameObject.Instantiate (tree, gameObject.transform);
			tempTree.name = a.ToString() + " - ";
			tempTree.transform.localPosition = new Vector3(0, 0, 5 * a);
			trees[a] = tempTile;
		}
	}

	void Update ()
	{

	}
}
