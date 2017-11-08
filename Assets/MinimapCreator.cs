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
    private float mapPosXFloat;
    private float mapPosYFloat;
    private int mapPosX;
    private int mapPosY;
    private int tileIndex;
    public float radius;
    private float radSq;
    private int radX;
    private int radY;
    private Color col;
    private int startTile;
    public Color home; // = new Color(255, 100, 50);
    public Color playerColor; // = new Color(0, 200, 150);
    public Color blank; // = new Color(200, 200, 100);
    public Color river; // = new Color(50, 100, 255);
    private float[] noiseValues;

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

        // Establish a start tile as a home for the player.
        startTile = Mathf.RoundToInt(tileNum) * Mathf.RoundToInt(player.transform.localPosition.z * tileNum / mapBounds + tileNum / 2) + Mathf.RoundToInt(player.transform.localPosition.x * tileNum / mapBounds + tileNum / 2);
        // Debug.Log(startTile.ToString());

        noiseValues = new float[tiles.Count * 3];
        for (int i = 0; i < tiles.Count * 3; i++)
        {
            noiseValues[i] = Random.value;
        }
	}

    // Update is called once per frame
    void Update()
    {

        // Scale position of player to the scale of the map, then round it to the nearest int.
        mapPosXFloat = player.transform.localPosition.x * tileNum / mapBounds + tileNum / 2;
        mapPosYFloat = player.transform.localPosition.z * tileNum / mapBounds + tileNum / 2;

        mapPosX = Mathf.RoundToInt(mapPosXFloat);
        mapPosY = Mathf.RoundToInt(mapPosYFloat);

        // Establish a vision radius.
        radSq = radius * radius;
        // Narrow it down to a rectangle
        for (int y = Mathf.RoundToInt(-1 * radius); y <= radius;  y++)
        {
            for (int x = Mathf.RoundToInt(-1 * radius); x <= radius; x++)
            {
                // Now we have a smaller set of data to check.
                // If we hadn't done this, it would be an insane amount of checks
                // If this doesn't work out well in terms of speed, we can do this every 10 updates and it wouldn't be bad at all. Maybe even 100.
                // Now we check distance from absolute player position - not just int map pos.
                // Since planes are built from the center and not the corner, you can just use the x and y.
                // Now start the checks
                radX = mapPosX + x;
                radY = mapPosY + y;
                // Check it it's in the bounds of the map
                if (radX >= 0 && radX < tileNum && radY >= 0 && radY < tileNum)
                {
                    // Check distance
                    if (Mathf.Pow(mapPosXFloat - radX, 2) + Mathf.Pow(mapPosYFloat - radY, 2) < radSq)
                    {
                        tileIndex = Mathf.RoundToInt(tileNum) * radY + radX;
                        // Debug.Log("TileNum = " + tileNum.ToString() + " & radY = " + radY.ToString() + " & radX = " + radX.ToString());
                        GameObject temp = tiles[tileIndex] as GameObject;

                        // Conditional logic for what color it should be goes here. Until then...
                        if ( tileIndex == startTile )
                        {
                            col = home;
                        }
                        else { col = blank * new Color(noiseValues[3 * tileIndex]/2, noiseValues[3 * tileIndex + 1], noiseValues[3 * tileIndex + 2]/2); }
                        temp.GetComponent<Renderer>().material.color = col;
                    }
                }
            }
        }

        // Now do the center one in a different color
        // Debug.Log(mapPosX.ToString() + mapPosY.ToString());
        tileIndex = Mathf.RoundToInt(tileNum) * mapPosY + mapPosX;
        // Debug.Log(tileIndex.ToString());

        // Check if the player is out of the bounds of the minimap
        // if (tileIndex >= 0 && tileIndex <= tiles.Count)
        // This method works to prevent errors, but doesn't work to prevent overflow within the length.
        if (mapPosX >= 0 && mapPosX < tileNum && mapPosY >= 0 && mapPosY < tileNum)
        {
            // Debug.Log(tiles[tileIndex].ToString());
            GameObject temp = tiles[tileIndex] as GameObject;
            temp.GetComponent<Renderer>().material.color = playerColor;
        }

    }
}