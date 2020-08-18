using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnableScrollView : MonoBehaviour
{
    public Canvas currentCanvas;
    public Sprite[] sprites; // array with the images of the buttons
    public Sprite[] spritesPressed; // array with the images of the buttons when pressed
    public Button[] buttons; // array with the buttons to change the objects category
    public Canvas[] canvasObjects; // array with the canvases of the objects    
    public Button btn; 

    void Start () 
    {
        for (int i = 1; i < canvasObjects.Length; i++)
        {            
            canvasObjects[i].GetComponent<Canvas>().enabled = false;             
        } 
        canvasObjects[0].GetComponent<Canvas>().enabled = true;
        buttons[0].image.sprite = spritesPressed[0];          

        Button btn1 = btn.GetComponent<Button>();
        btn1.onClick.AddListener(ToggleCanvas);             
    }

    // function to change the objects shown in the "objects bar"
    public void ToggleCanvas()
    {                                             
        for (int i = 0; i < canvasObjects.Length; i++)
        {                                      
            if (btn.name == "BtnObjects"+i)
            {                          
                if (currentCanvas.enabled == false)
                { 
                    for (int j = 0; j < canvasObjects.Length; j++)
                    {
                        canvasObjects[j].enabled = false;                        
                        buttons[j].image.sprite = sprites[j];                           
                    }  
                    currentCanvas.enabled = true; 
                    buttons[i].image.sprite = spritesPressed[i];                                                                                                                                                                                                                                                                                                                         
                }                                     
            }                                                              
        }                           
    }

}
