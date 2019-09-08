using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]

public class DragDrop: MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private Vector3 v3CollPosition;

    public GameObject tile;
    bool beingDragged;
    bool overValidTile;

   

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        beingDragged = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    void OnMouseDown()
    {
        
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        
    }

    void OnMouseDrag()
    {
        beingDragged = true;
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.z);

        
    }

    void OnMouseUp()
    {
        
        transform.position = endPosition;
        beingDragged = false;

        Debug.Log(endPosition);

        if (overValidTile == true)
        {
            tile.GetComponent<TileObj>().valid = false;
            tile.GetComponent<TileObj>().cardOnTile = this.gameObject;
        }

        
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("tile")) 
        {
            Debug.Log("enter");

            tile = col.gameObject.GetComponent<MouseHoverColor>().gameObject;
            endPosition = tile.GetComponent<Transform>().position;

            if (tile.GetComponent<TileObj>().valid == false)
            {

                overValidTile = false;

            }

            else overValidTile = true;
        }
    
    }


    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.CompareTag("tile"))
        {

            Debug.Log("exit");
            endPosition = startPosition;
            tile.GetComponent<TileObj>().valid = true;
            tile.GetComponent<TileObj>().cardOnTile = null;

        }

    }



}
