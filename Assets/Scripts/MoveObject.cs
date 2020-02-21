using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveObject : MonoBehaviour
{
    private string btnName = "";
    private GameObject obj; 
    public SelectObject sel = new SelectObject();        
    private int validator = 0;
    
    //function to move one object to the left, right, forward or backward
    void Update()
    {        
        if (sel != null)
        {
            obj = sel.GetGameobject();            
        }
        
        if (obj != null)                          
        {                                      
            if (Input.GetKey("left") || validator == 1)
            {                     
                //obj.transform.position = obj.transform.position - Vector3.left * -8f;
                obj.transform.Translate(-150 * Time.deltaTime, 0, 0, Space.World); 
                validator = 0;            
            } 
            else if (Input.GetKey("right") || validator == 2)
            {                     
                //obj.transform.position = obj.transform.position - Vector3.right * 10f;
                obj.transform.Translate(150 * Time.deltaTime, 0, 0, Space.World);
                validator = 0;   
            }
            else if (Input.GetKey("up") || validator == 3)
            {
                //obj.transform.position = obj.transform.position - Vector3.forward * 10f;
                obj.transform.Translate(0, 0, 150 * Time.deltaTime, Space.World);
                validator = 0;   
            } 
            else if (Input.GetKey("down") || validator == 4)
            {                    
                //obj.transform.position = obj.transform.position - Vector3.back * -10f;
                obj.transform.Translate(0, 0, -150 * Time.deltaTime, Space.World); 
                validator = 0; 
            }
            else if (Input.GetKey("f"))
            {
                //obj.transform.position = obj.transform.position - Vector3.forward * 10f;
                obj.transform.Translate(0, 150 * Time.deltaTime, 0, Space.World);
                validator = 0;   
            } 
            else if (Input.GetKey("d"))
            {                    
                //obj.transform.position = obj.transform.position - Vector3.back * -10f;
                obj.transform.Translate(0, -150 * Time.deltaTime, 0, Space.World); 
                validator = 0; 
            }                           
        }         
    }

    public void ChangeValidator(Button btn)
    {
        btnName = btn.name;      
        //Debug.Log(obj);                                                     
        if (btnName == "BtnLeft")
        {                                  
            validator = 1;
        } 
        else if (btnName == "BtnRight")
        {                     
            validator = 2; 
        }
        else if (btnName == "BtnForward")
        {
            validator = 3; 
        } 
        else if (btnName == "BtnBackward")
        {                    
            validator = 4; 
        }
    }
 
}
