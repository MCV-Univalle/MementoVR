using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Scenario : MonoBehaviour
{
    public GameObject[] objects;
    public DateTime initTime;      
    public DateTime finishTime;
    private int cont;
    private Button[] btns;

    void Start() {
        //SelectObject obj;        
        initTime = DateTime.Now;
        Debug.Log(initTime);
    }

    void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("Seleccion");
        //cont = objects.Length;
        SetCont(objects.Length);
        //Debug.Log(cont);         
    }     

    private void SetCont(int contador)
    {
        this.cont = contador;
    }

    public int GetCont()
    {
        return this.cont;
    }

    /* public void DissableButton()
    {
        if (cont == 99)
        {
            for (int i = 0; i < cont; i++)
            {
                btns[i] = GameObject.FindGameObjectWithTag("Button").GetComponent<Button>();
                btns[i] = GameObject.FindGameObjectWithTag("BtnRotate").GetComponent<Button>();
                btns[i] = GameObject.FindGameObjectWithTag("Normal").GetComponent<Button>();

                btns[i].interactable = false;
            }                        
        } else
        {
            
        }
    } */

    public void SaveScenario()
    {
        finishTime = DateTime.Now;
        SaveGame.Save(this);        
    }    

    // public void LoadScenario()
    // {
    //     SaveGame.Load();
    // }

}
