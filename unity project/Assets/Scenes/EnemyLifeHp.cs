using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLifeHp : MonoBehaviour
{

    public int startLifre, maxLife;
    public Slider lifeSlider;


    // Use this for initialization
    void Start()
    {

        maxLife = 100;
        lifeSlider = gameObject.GetComponent<Slider>();
        lifeSlider.value = maxLife;
        

    }

    // Update is called once per frame
    void Update()
    {

        GameObject.Find("EnemyLifeNumber").GetComponent<Text>().text = lifeSlider.value.ToString();

    }

    public void Hurt(int i)
    {

        lifeSlider.value = lifeSlider.value - i;

    }

}
