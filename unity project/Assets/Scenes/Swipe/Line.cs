using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

    public LineRenderer line;
    private Vector2 mousePosition;
    bool lineOn;

    // Use this for initialization
    void Start () {

        lineOn = false;
        
	}

   
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) & line != true) {
            lineOn = true;
            Debug.Log("PositionMouse");
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Instantiate(line, mousePosition, Quaternion.Euler(0.0f, 0.0f, 0.0f));
            line.SetPosition(0, mousePosition);
            line.SetPosition(1, mousePosition*10);
        }
        /*
        if (lineOn == true)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            line.SetPosition(1, mousePosition);
        }*/
    }
}
