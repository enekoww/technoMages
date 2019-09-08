using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdasd : MonoBehaviour {

    LineRenderer line;
    bool firstClick;
    Vector2 mousePos;
    int counter;

	// Use this for initialization
	void Start () {

        line = GetComponent<LineRenderer>();
        line.positionCount = 0;
        firstClick = true;
        counter = 0;

    }
	

	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButtonDown(0))
        {
           
            if (firstClick == true) {

                Debug.Log("esaease");

                line.positionCount++;
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                line.SetPosition(0, mousePos);

            }

            

            

        }

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        line.SetPosition(1, mousePos);
        //line.SetPosition(1, Camera.main.ScreenToWorldPoint(Input.mousePosition));






    }
}
