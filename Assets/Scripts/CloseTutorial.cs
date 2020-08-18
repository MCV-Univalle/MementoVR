using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseTutorial : MonoBehaviour
{
    //private Canvas canvasMessage;        
    public Canvas canvasMessage;     
    public Button btn;   
    public Canvas[] canvases;   
    private int index = 0;  

    // Start is called before the first frame update
    void Start()
    {        
        //canvasMessage = GameObject.Find("CanvasMessage").GetComponent<Canvas>();

        for (int i = 0; i < canvases.Length; i++)
        {           
            canvases[i] = GameObject.Find("CanvasMessage"+i).GetComponent<Canvas>(); 
            canvases[i].GetComponent<Canvas>().enabled = true;//false;
        }

        Button btn1 = btn.GetComponent<Button>();
        btn1.onClick.AddListener(NextPreviousCloseMessage);  
    }

    // show the next message in the tutorial depending on the button
    public void NextPreviousCloseMessage() 
    {                
        //if button accept is pressed
        if (btn.name == "BtnAccept")
        {            
            canvasMessage.GetComponent<Canvas>().enabled = false;               
        } else if (btn.name == "BtnBack")
        {                        
            for (int i = 0; i < canvases.Length; i++)
            {                  
                if (canvasMessage == canvases[i])
                {
                    index = i;
                    //Debug.Log(index);
                    canvases[index-1].GetComponent<Canvas>().enabled = true;             
                }                
            }            
            //canvasMessage.GetComponent<Canvas>().enabled = false;
        } else if (btn.name == "BtnClose")
        {            
            for (int i = 0; i < canvases.Length; i++)
            {      
                canvases[i].GetComponent<Canvas>().enabled = false;
            }
        } else if (btn.name == "BtnTutorial")
        {            
            for (int i = 0; i < canvases.Length; i++)
            { 
                canvases[i].GetComponent<Canvas>().enabled = true; // show the tutorial                      
            }       
        }        
    }
}
