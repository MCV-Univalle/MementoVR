using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateObject : MonoBehaviour
{
    public GameObject gameobject;
    public Button btn;
    private const string tagButton = "Button";
    private const string tagRotate = "BtnRotate";
    private const string tagNormal = "Normal";              

    void Start()
    {
        Button btn1 = btn.GetComponent<Button>();
        btn1.onClick.AddListener(InstantiateObj);            
    }

    // function to instantiate an object in the scene
    public void InstantiateObj()    
    {           
        if (btn.CompareTag(tagButton)) 
        {
            Instantiate(gameobject, new Vector3(730,25,910), Quaternion.identity);                        
        }
        else if (btn.CompareTag(tagRotate))
        {
            Instantiate(gameobject, new Vector3(730,1,910), new Quaternion(0,90,90,0));                                  
        }
        else if (btn.CompareTag(tagNormal))
        {
            Instantiate(gameobject, new Vector3(730,1,910), Quaternion.identity);                           
        }                                      
    }
}
