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
    private const string tagHigher = "Altura";   
    private const string tagHigherRot = "AlturaYRotacion";    
    private Canvas canvasMessageObjectAdded;   

    void Start()
    {
        Button btn1 = btn.GetComponent<Button>();
        btn1.onClick.AddListener(InstantiateObj);   

        canvasMessageObjectAdded = GameObject.Find("MessageObjectAdded").GetComponent<Canvas>(); 
        canvasMessageObjectAdded.GetComponent<Canvas>().enabled = false;         
    }   

    // function to instantiate an object in the scene
    public void InstantiateObj()    
    {           
        if (btn.CompareTag(tagButton)) 
        {
            Instantiate(gameobject, new Vector3(730,25,910), Quaternion.identity);  
            // to show the message for certain time is necessary to have the exact time when the message is showed 
            StartCoroutine(countThreeSeconds());
        }
        else if (btn.CompareTag(tagRotate))
        {
            Instantiate(gameobject, new Vector3(730,1,910), new Quaternion(0,90,90,0));   
            StartCoroutine(countThreeSeconds());                                                          
        }
        else if (btn.CompareTag(tagNormal))
        {
            Instantiate(gameobject, new Vector3(730,1,910), Quaternion.identity);   
            StartCoroutine(countThreeSeconds());                                    
        }    
        else if (btn.CompareTag(tagHigher))
        {
            Instantiate(gameobject, new Vector3(730,25,910), new Quaternion(0,90,90,0));  
            StartCoroutine(countThreeSeconds());                                         
        }   
        else if (btn.CompareTag(tagHigherRot))
        {
            Instantiate(gameobject, new Vector3(730,25,910), new Quaternion(0,90,0,0));  
            StartCoroutine(countThreeSeconds());                                         
        }                                       
    }

    IEnumerator countThreeSeconds()
    {
        canvasMessageObjectAdded.GetComponent<Canvas>().enabled = true; 
        yield return new WaitForSeconds(3);
        canvasMessageObjectAdded.GetComponent<Canvas>().enabled = false;
    }
}
