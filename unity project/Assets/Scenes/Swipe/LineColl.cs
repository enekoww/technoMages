using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColl : MonoBehaviour {

   public List<GameObject> collCards = new List<GameObject>();
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
        //GetComponent<Collider>().col

	}

    void OnTriggerEnter(Collider coll) {

        if (!collCards.Contains(coll.gameObject)) {

            collCards.Add(coll.gameObject);
            GameObject card = coll.gameObject;

            if (!GameObject.Find("SpellCard").GetComponent<GlowOnUsable>().swipePattern.Contains(card.GetComponent<ManaDefinition>().type))
            {
                GameObject.Find("SpellCard").GetComponent<GlowOnUsable>().swipePattern.Add(card.GetComponent<ManaDefinition>().type);
            }

        }
        coll.gameObject.GetComponent<GlowOnSwipe>().Glow();

    }
}
