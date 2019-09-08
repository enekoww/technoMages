using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverColor : MonoBehaviour {

    Color startColor;
    public Color mouseColor;
   
	// Use this for initialization
	void Start () {

        startColor = GetComponent<Renderer>().material.GetColor("_Color");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseEnter() {

        GetComponent<Renderer>().material.SetColor( "_Color",mouseColor);
    }

    void OnMouseExit() {
               
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
        
    }
}
