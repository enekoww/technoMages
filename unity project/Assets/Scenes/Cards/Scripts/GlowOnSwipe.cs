using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnSwipe : MonoBehaviour {

    Behaviour halo;
    public bool active;

	// Use this for initialization
	void Start () {

        halo = (Behaviour)GetComponent("Halo");

    }
	
	// Update is called once per frame
	void Update () {
		


	}

    public void Glow() {

        halo.enabled = true;

        InvokeRepeating("UnGlow", 1.5f,1);
        active = true;

    }

    public void UnGlow() {

        halo.enabled = false;
        CancelInvoke("UnGlow");
        active = false;

    }

}
