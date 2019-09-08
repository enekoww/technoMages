using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2018 TheFlyingKeyboard and released under MIT License 
// theflyingkeyboard.net 

public class LineDrawer : MonoBehaviour
{
    private LineRenderer line;
    private Vector2 mousePosition, mousePositionOld;
    public GameObject lineColl;
    public Quaternion rot, rotOld;
    bool firstClick;
    public List<GameObject> collArray;
    [SerializeField] private bool simplifyLine = false;
    [SerializeField] private float simplifyTolerance = 0.02f;

    private void Awake() {

        InvokeRepeating("DestroyArray", 2, 1);
        InvokeRepeating("DrawColl", 0, 1 / 120f);
        
        

    }

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        Destroy(this.gameObject, 1.5f);
        firstClick = true;
        





    }
    private void Update()
    {
        if (Input.GetMouseButton(1)) //Or use GetKey with key defined with mouse button
        {



            if (firstClick == true) {

                
                firstClick = false;
            }
            
           
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, mousePosition);

            


        }


        if (Input.GetMouseButtonUp(1))
        {
            CancelInvoke("DrawColl");
            

            if (simplifyLine)
            {
                line.Simplify(simplifyTolerance);
            }
            enabled = false; //Making this script stop
        }
    }


    void DrawColl() {

       

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
            rot = Quaternion.LookRotation(mousePosition - mousePositionOld);

        




        if (rot.Equals(new Vector3(0, 0, 0))) {

            rot = rotOld;
        }

        lineColl = Instantiate(lineColl, mousePosition, rot);
        collArray.Add(lineColl);
        Destroy(lineColl, 1.5f);

       
        mousePositionOld = mousePosition;
        rotOld = rot;

        

    }


    void DestroyArray() {

        foreach (GameObject g in collArray) {
                                  
            Destroy(g);

        }

    }

    
}