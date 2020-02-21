using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableConfigurePanel : MonoBehaviour
{
    private GameObject obj; 
    public SelectObject sel = new SelectObject(); 
    private Canvas canvasConfig;

    // Start is called before the first frame update
    void Start()
    {        
        canvasConfig = GameObject.Find("CanvasConfiguration").GetComponent<Canvas>();
        canvasConfig.GetComponent<Canvas> ().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetSelectedObject();
        
        if (obj != null)
        {               
            canvasConfig.GetComponent<Canvas> ().enabled = true;
        } else
        {
            canvasConfig.GetComponent<Canvas> ().enabled = false;        
        }
    }

    private void GetSelectedObject()      
    {        
        if (sel != null)
        {
            obj = sel.GetGameobject();            
        }        
    }
}
