using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RemoveObject : MonoBehaviour
{
    GameObject obj;
    public SelectObject sel = new SelectObject();
    int validator = 0;

    void Update()
    {       
        if (validator == 1)
        {                                    
            //obj.transform.position = obj.transform.position - Vector3.left * -10f;
            Destroy(obj);
            validator = 0; 
            obj = null;                                              
        }                 
    }

    // Update is called once per frame
    public void RemoveObj()
    {
        validator = 1;  
        Debug.Log("delete");           
        obj = sel.GetGameobject();
    }
}
