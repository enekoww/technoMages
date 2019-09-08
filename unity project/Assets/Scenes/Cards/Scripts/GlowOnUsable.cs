using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlowOnUsable : MonoBehaviour {

    public GameObject grid, energySlider, fireball;
    List<TileObj> tiles;
    int manCards, activeMana;
    Behaviour halo;
    public List<string> pattern, swipePattern;
    

    public int energyNeeded;



    // Use this for initialization
    void Start() {

        energySlider = GameObject.Find("EnergySlider");
        grid = GameObject.Find("Grid");
        manCards = 0;
        halo = (Behaviour)GetComponent("Halo");
        pattern = new List<string>() { "Fire", "Water", "Light" };

        


    }

    // Update is called once per frame
    void Update() {

        tiles = grid.gameObject.GetComponent<GridObj>().tiles;

        foreach (TileObj tile in tiles)
        {

            if (tile.cardOnTile != null)
            {

                manCards++;

                if (tile.cardOnTile.GetComponent<GlowOnSwipe>().active == true)
                {

                    activeMana++;
                }



            }
        }



        if (manCards >= 3 && energySlider.GetComponent<Slider>().value >= energyNeeded)
        {

          
           
            halo.enabled = true;
        }

        if (activeMana >= 3 && energySlider.GetComponent<Slider>().value >= energyNeeded)
        {
            

            CastSpell();

        }


        else
        {
            if (manCards < 3 || energySlider.GetComponent<Slider>().value < energyNeeded)
            {

                halo.enabled = false;
            }
        }



        manCards = 0;
        activeMana = 0;

    }


    void CastSpell()
    {

        if (CheckMatch(swipePattern,pattern))
        {
            Debug.Log("asdasdasdasdasdasdasdasdasd");
            GameObject fr = Instantiate(fireball);
            fr.GetComponent<LaunchFireball>().startMarker = GetComponent<Transform>();
            fr.GetComponent<LaunchFireball>().endMarker = GameObject.Find("Objective").GetComponent<Transform>();
            energySlider.GetComponent<Slider>().value = energySlider.GetComponent<Slider>().value - energyNeeded;

        }

        else { swipePattern.Clear(); }
    }

    bool CheckMatch(List<string> a, List<string> b)
    {
        if (a.Count != b.Count)
            return false;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }

}
