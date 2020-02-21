using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RotateObject : MonoBehaviour
{
    private string btnName = "";
    private GameObject obj;
    public SelectObject sel = new SelectObject(); 
    private int validator = 0;

    // Update is called once per frame
    void Update()
    {                
        if (sel != null)
        {
            obj = sel.GetGameobject();            
        }

        if (obj != null)                          
        {
            if (Input.GetKey("a") || validator == 1)
            {            
                obj.transform.Rotate(0, -45, 0, Space.World);
                validator = 0;    
            }
            else if (Input.GetKey("s") || validator == 2)    
            {
                obj.transform.Rotate(0, 45, 0, Space.World);
                validator = 0; 
            }  
        }                                                              
    }

    public void Rotate(Button btn)
    {                     
        btnName = btn.name;      
        //Debug.Log(obj);                                                     
        if (btnName == "BtnRotateLeft")
        {                                  
            validator = 1;
        } 
        else if (btnName == "BtnRotateRight")
        {                     
            validator = 2; 
        }   
    }    
}
