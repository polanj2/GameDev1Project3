using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCreator : MonoBehaviour {
    public float tileNum = 10;
    public float mapBounds = 100;
    public float mapCenterX = 0;
    public float mapCenterY = 0;
    public ArrayList tiles;
    public GameObject plane;
    private GameObject tempTile;
    public GameObject player;
    private int mapPosX;
    private int mapPosY;
    private int tileIndex;

	// Use this for initialization
	void Start ()
    {
        tiles = new ArrayList();
        for (int a = 0; a < tileNum; a++)
        {
            for (int b = 0; b < tileNum; b++)
            {
                tempTile = GameObject.Instantiate(plane, gameObject.transform);
                tempTile.transform.localScale = new Vector3(1.0f / tileNum, 1.0f / tileNum, 1.0f / tileNum);
                tempTile.transform.localPosition = new Vector3(b * 10 / tileNum - 5 + tempTile.transform.localScale.x * 5, 0, a * 10 / tileNum - 5 + tempTile.transform.localScale.y * 5);
                tempTile.name = a.ToString() + " - " + b.ToString();
                tiles.Add(tempTile);
            }
        }
	}

    // Update is called once per frame
    void Update()
    {

        // Scale position of player to the scale of the map, then round it to the nearest int.
        mapPosX = Mathf.RoundToInt(player.transform.localPosition.x * tileNum / mapBounds + tileNum / 2);
        mapPosY = Mathf.RoundToInt(player.transform.localPosition.z * tileNum / mapBounds + tileNum / 2);

        // Debug.Log(mapPosX.ToString() + mapPosY.ToString());
        tileIndex = Mathf.RoundToInt(tileNum) * mapPosY + mapPosX;

        // Check if the player is out of the bounds of the minimap
        // if (tileIndex >= 0 && tileIndex <= tiles.Count)
        // This method works to prevent errors, but doesn't work to prevent overflow within the length.
        if (mapPosX >= 0 && mapPosX < tileNum && mapPosY >= 0 && mapPosY < tileNum)
        {
            // Debug.Log(tiles[tileIndex].ToString());
            GameObject temp = tiles[tileIndex] as GameObject;
            temp.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }

    }
}