using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseTutorial : MonoBehaviour
{
    //private Canvas canvasMessage;        
    public Canvas canvasMessage;     
    public Button btn;    

    // Start is called before the first frame update
    void Start()
    {        
        //canvasMessage = GameObject.Find("CanvasMessage").GetComponent<Canvas>();
        canvasMessage.GetComponent<Canvas>().enabled = true;

        Button btn1 = btn.GetComponent<Button>();
        btn1.onClick.AddListener(Accept);  
    }

    // Update is called once per frame
    void Update()
    {        
        
    }

    public void Accept()//Button btn) 
    {
        //if button accept is pressed
        if (btn.name == "BtnAccept")
        {
            canvasMessage.GetComponent<Canvas>().enabled = false;
        }
    }
}
