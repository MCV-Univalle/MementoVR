using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnableScrollView : MonoBehaviour
{
    private Canvas CanvasObject1; 
    private Canvas CanvasObject2;
    private Canvas CanvasObject3;
    private Canvas CanvasObject4;
    private Canvas CanvasObject5;
    public Sprite[] sprites;
    public Sprite[] spritesPressed;
    public Button[] buttons;
    public Canvas[] canvasObjects;    
    private Scenario scenario = new Scenario(); 
    private int cont;     

    void Start () 
    {
        /* for (int i = 1; i < canvasObjects.Length; i++)
        {            
            canvasObjects[0].GetComponent<Canvas>().enabled = true;
            canvasObjects[i].GetComponent<Canvas>().enabled = false;
        } */
         
        CanvasObject1 = GameObject.Find("CanvasScrollView1").GetComponent<Canvas>();
        CanvasObject1.GetComponent<Canvas> ().enabled = true;
        
        CanvasObject2 = GameObject.Find("CanvasScrollView2").GetComponent<Canvas>();
        CanvasObject2.GetComponent<Canvas> ().enabled = false;
        
        CanvasObject3 = GameObject.Find("CanvasScrollView3").GetComponent<Canvas>();
        CanvasObject3.GetComponent<Canvas> ().enabled = false;
        
        CanvasObject4 = GameObject.Find("CanvasScrollView4").GetComponent<Canvas>();
        CanvasObject4.GetComponent<Canvas> ().enabled = false;

        CanvasObject5 = GameObject.Find("CanvasScrollView5").GetComponent<Canvas>();
        CanvasObject5.GetComponent<Canvas> ().enabled = false;  
 
        buttons[0].image.sprite = spritesPressed[0];              
    }

    void Update()
    {
        //DissableButton();
    }

    public void ToggleCanvas (Button btn)
    {        
        //if (!EventSystem.current.IsPointerOverGameObject())
        //{            
            
            //int index = 0;            
            //for (int j = 1; j <= buttons.Length; j++)
            //{
                /* if (buttons[j-1].name == "BtnObjects" + j)
                {   
                    for (int i = 0; i < canvasObjects.Length; i++)
                    {   
                        if (buttons[i].name == "BtnObjects" + i+1)
                        {                        
                        if (canvasObjects[index].enabled == false && canvasObjects[i].enabled == true) 
                        {                                                                                                                                                                                                  
                            canvasObjects[i].enabled = false;                                
                            canvasObjects[index].enabled = true;                            
                            Debug.Log(index);
                            buttons[i].image.sprite = sprites[i]; 
                            buttons[index].image.sprite = spritesPressed[index];                                                                                                                                                                                                                           
                        }
                        index++;
                    }                                                                                                                                                
                } */                       
            //}        
            
            
            if (btn.name == "BtnObjects1")
            {                    
                if (CanvasObject1.enabled == false && (CanvasObject2.enabled == true || CanvasObject3.enabled == true
                    || CanvasObject4.enabled == true || CanvasObject5.enabled == true)) 
                {                     
                    CanvasObject1.GetComponent<Canvas> ().enabled = true;
                    CanvasObject2.GetComponent<Canvas> ().enabled = false;
                    CanvasObject3.GetComponent<Canvas> ().enabled = false;
                    CanvasObject4.GetComponent<Canvas> ().enabled = false;
                    CanvasObject5.GetComponent<Canvas> ().enabled = false;
                    buttons[0].image.sprite = spritesPressed[0];
                    buttons[1].image.sprite = sprites[1];
                    buttons[2].image.sprite = sprites[2];
                    buttons[3].image.sprite = sprites[3];
                    buttons[4].image.sprite = sprites[4];
                } 
            } 
            else if (btn.name == "BtnObjects2")
            {                
                if (CanvasObject2.enabled == false && (CanvasObject1.enabled == true || CanvasObject3.enabled == true
                    || CanvasObject4.enabled == true || CanvasObject5.enabled == true)) 
                {                    
                    CanvasObject1.GetComponent<Canvas> ().enabled = false;
                    CanvasObject2.GetComponent<Canvas> ().enabled = true;
                    CanvasObject3.GetComponent<Canvas> ().enabled = false;
                    CanvasObject4.GetComponent<Canvas> ().enabled = false;
                    CanvasObject5.GetComponent<Canvas> ().enabled = false;
                    buttons[0].image.sprite = sprites[0];
                    buttons[1].image.sprite = spritesPressed[1];
                    buttons[2].image.sprite = sprites[2];
                    buttons[3].image.sprite = sprites[3];
                    buttons[4].image.sprite = sprites[4];
                } 
            }
            else if (btn.name == "BtnObjects3")       
            {
                buttons[2].image.sprite = spritesPressed[2];
                if (CanvasObject3.enabled == false && (CanvasObject1.enabled == true || CanvasObject2.enabled == true
                    || CanvasObject4.enabled == true || CanvasObject5.enabled == true)) 
                {                    
                    CanvasObject1.GetComponent<Canvas> ().enabled = false;
                    CanvasObject2.GetComponent<Canvas> ().enabled = false;
                    CanvasObject3.GetComponent<Canvas> ().enabled = true;
                    CanvasObject4.GetComponent<Canvas> ().enabled = false;
                    CanvasObject5.GetComponent<Canvas> ().enabled = false;
                    buttons[0].image.sprite = sprites[0];
                    buttons[1].image.sprite = sprites[1];
                    buttons[2].image.sprite = spritesPressed[2];
                    buttons[3].image.sprite = sprites[3];
                    buttons[4].image.sprite = sprites[4];
                }
            }
            else if (btn.name == "BtnObjects4")
            {
                buttons[3].image.sprite = spritesPressed[3];
                if (CanvasObject4.enabled == false && (CanvasObject1.enabled == true || CanvasObject2.enabled == true
                    || CanvasObject3.enabled == true || CanvasObject5.enabled == true)) 
                {                    
                    CanvasObject1.GetComponent<Canvas> ().enabled = false;
                    CanvasObject2.GetComponent<Canvas> ().enabled = false;
                    CanvasObject3.GetComponent<Canvas> ().enabled = false;
                    CanvasObject4.GetComponent<Canvas> ().enabled = true;
                    CanvasObject5.GetComponent<Canvas> ().enabled = false;
                    buttons[0].image.sprite = sprites[0];
                    buttons[1].image.sprite = sprites[1];
                    buttons[2].image.sprite = sprites[2];
                    buttons[3].image.sprite = spritesPressed[3];
                    buttons[4].image.sprite = sprites[4];
                }                
            }
            else if (btn.name == "BtnObjects5")
            {
                buttons[4].image.sprite = spritesPressed[4];
                if (CanvasObject5.enabled == false && (CanvasObject1.enabled == true || CanvasObject2.enabled == true
                    || CanvasObject3.enabled == true || CanvasObject4.enabled == true)) 
                {                    
                    CanvasObject1.GetComponent<Canvas> ().enabled = false;
                    CanvasObject2.GetComponent<Canvas> ().enabled = false;
                    CanvasObject3.GetComponent<Canvas> ().enabled = false;
                    CanvasObject4.GetComponent<Canvas> ().enabled = false;
                    CanvasObject5.GetComponent<Canvas> ().enabled = true;
                    buttons[0].image.sprite = sprites[0];
                    buttons[1].image.sprite = sprites[1];
                    buttons[2].image.sprite = sprites[2];
                    buttons[3].image.sprite = sprites[3];
                    buttons[4].image.sprite = spritesPressed[4];
                }
            } 
        //}
    }

    public void DissableButton()
    {    
        cont = scenario.GetCont();
        Debug.Log(cont);

        if (cont == 99)
        {
            CanvasObject1 = GameObject.Find("CanvasScrollView1").GetComponent<Canvas>();
            CanvasObject1.GetComponent<Canvas> ().enabled = false;
            
            CanvasObject2 = GameObject.Find("CanvasScrollView2").GetComponent<Canvas>();
            CanvasObject2.GetComponent<Canvas> ().enabled = false;
            
            CanvasObject3 = GameObject.Find("CanvasScrollView3").GetComponent<Canvas>();
            CanvasObject3.GetComponent<Canvas> ().enabled = false;
            
            CanvasObject4 = GameObject.Find("CanvasScrollView4").GetComponent<Canvas>();
            CanvasObject4.GetComponent<Canvas> ().enabled = false;

            CanvasObject5 = GameObject.Find("CanvasScrollView5").GetComponent<Canvas>();
            CanvasObject5.GetComponent<Canvas> ().enabled = false;   


        } 
    }

}
