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
    private Canvas canvasMessageObjectAdded;
    public Button btn;

    void Start()
    {
        //Button btn1 = btn.GetComponent<Button>();
        //btn1.onClick.AddListener(InstantiateObj);   
        canvasMessageObjectAdded = GameObject.Find("MessageObjectDeleted").GetComponent<Canvas>(); 
        canvasMessageObjectAdded.GetComponent<Canvas>().enabled = false;         
    }

    void Update()
    {       
        if (validator == 1)
        {                                    
            //obj.transform.position = obj.transform.position - Vector3.left * -10f;
            Destroy(obj);
            validator = 0; 
            obj = null;    
            StartCoroutine(countThreeSeconds());                                          
        }                 
    }

    // Update is called once per frame
    public void RemoveObj()
    {
        validator = 1;                   
        obj = sel.GetGameobject();
    }

    IEnumerator countThreeSeconds()
    {
        canvasMessageObjectAdded.GetComponent<Canvas>().enabled = true; 
        yield return new WaitForSeconds(3);
        canvasMessageObjectAdded.GetComponent<Canvas>().enabled = false;
    }
}
