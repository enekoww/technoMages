using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileObj : MonoBehaviour {


    public bool bOnTile;
    public Vector2 vGridPos;
    public Vector2 vPosition;
    public Vector3 vTileSize;
    public Color cColor;
    public bool valid;
    //public bool boost;
  


    public GameObject cardOnTile;

    Renderer rend;


    // Use this for initialization
    void Start()
    {

        cardOnTile = null;
        valid = true;

        transform.localScale = vTileSize;
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", cColor);



    }

    // Update is called once per frame
    void Update () {

        try
        {

        }

        catch (Exception e) { }
	}

  

   
}
