using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Proyecto26;

[System.Serializable]
public class Scenario
{    
    public string init;
    public string finish;
    public string date;
    public string duration;
    public string scenarioName;
    public string userID;

    public Scenario() {            
        init = ScenarioData.initialTime.ToString();
        finish = ScenarioData.finishTime.ToString();
        duration = ScenarioData.duration.ToString();
        date = ScenarioData.date;//.ToString();
        scenarioName = ScenarioData.scenarioName; 
        userID = ScenarioData.userID;
    }
}
