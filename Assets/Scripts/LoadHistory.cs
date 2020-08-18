using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadHistory : MonoBehaviour
{
    // text from the screen Historial
    private static Canvas canvasInformation;      
    private static TextMeshProUGUI dateText; 

    private ScenarioData scData = new ScenarioData();
    private Scenario sc = new Scenario();
    private Scenario[] scenarios;

    private string response = "";   

    void Start()
    {
        canvasInformation = GameObject.Find("CanvasInfo").GetComponent<Canvas>();        
        canvasInformation.GetComponent<Canvas>().enabled = false; 

        response = "";               
    }    

    private void OnGUI() 
    {
        Event e = Event.current;
        if (e.button == 0)
        {
            ScenarioData.LoadAll();
            scenarios = scData.GetObtainedScenarios();
        }                             
    }

    public void Load(Button btn)
    {              
        canvasInformation.GetComponent<Canvas>().enabled = true;
        dateText = GameObject.Find("Date").GetComponent<TextMeshProUGUI>();                
        
        btn.GetComponent<Button>().enabled = false;
        
        if (scenarios != null) 
        {
            response = "";
            foreach (var scenario in scenarios)
            {                                                        
                string r = $"{scenario.date}              {scenario.scenarioName}              {scenario.duration}\n";  
                response = string.Concat(response, r);                     
            }  
            dateText.SetText(response);
        } else  
        {            
            response = "No hay historial";             
            dateText.SetText(response);
        }        
    }
}