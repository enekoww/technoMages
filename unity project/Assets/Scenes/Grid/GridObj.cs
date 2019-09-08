using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObj : MonoBehaviour {

    Vector2 vLocation;
    public int gridX, gridY;
    public GameObject tile;
    public List<TileObj> tiles;
    public float offset;

	// Use this for initialization
	void Start () {

       tiles = new List<TileObj>();
       TileObj tileObj;

        vLocation = transform.position;

        for (int i = 0; i < 4; i++)
        {

            for (int j = 0; j < 4; j++)
            {
              tileObj = Instantiate(tile, new Vector3(vLocation.x +  1.3f*i, vLocation.y + 1.5f*j, 0.05f), transform.rotation).GetComponent<TileObj>();
              tileObj.vGridPos = new Vector2(i, j);
              tileObj.vTileSize = new Vector3(1, 1.2f, .1f);

              tiles.Add(tileObj);

            }
        }
   
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
