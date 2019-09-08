using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyScript : MonoBehaviour {

    public int startEnergy, maxEnergy;
    public Slider energySlider;


	// Use this for initialization
	void Start () {


        energySlider = gameObject.GetComponent<Slider>();
        energySlider.value = 0;
        InvokeRepeating("AddEnergy", 1, 1);
        
	}
	
	// Update is called once per frame
	void Update () {

        GameObject.Find("EnergyNumber").GetComponent<Text>().text = energySlider.value.ToString();
       
	}

    public void AddEnergy() {

        if (energySlider.value != energySlider.maxValue)
        energySlider.value += 1;
    }

}
