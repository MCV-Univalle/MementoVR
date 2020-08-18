using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Proyecto26; // Rest client
using TMPro;
using GameDevWare.Serialization; // serialization

public class ScenarioData: MonoBehaviour
{    
    public static DateTime initTime;      
    public static DateTime initialTime;  
    public static DateTime finishTime;
    public static TimeSpan duration;
    private int day = 0;
    private int month = 0;
    private int year = 0;

    public static string userID;
    public static string date;
    public static string scenarioName;

    private Scenario scenario = new Scenario();   
    private static Scenario obtainedScenario = new Scenario();  
    private static Scenario[] obtainedScenarios; 

    private User user = new User();
    private SignIn signin = new SignIn();
    private Canvas canvasMessageSaved;  
    private GameObject scenarioGameObject;
    // text from the screen Historial
    private static Canvas canvasInformation;      
    private static TextMeshProUGUI dateText;  

    private static string dbName = ""; // your firebase project id here
    private static string database = $"https://{dbName}.firebaseio.com/";

    void Start() {  
        canvasMessageSaved = GameObject.Find("MessageSaved").GetComponent<Canvas>(); 
        canvasMessageSaved.GetComponent<Canvas>().enabled = false; 

        obtainedScenarios = null;

        initTime = DateTime.Now;

        day = initTime.Day;
        month = initTime.Month;
        year = initTime.Year;
        date = day + "-" + month + "-" + year;   

        user = signin.GetObtainedUser(); // logged in user
        userID = user.id; 

        // canvas from the screen Historial
        canvasInformation = GameObject.Find("CanvasInfo").GetComponent<Canvas>();
        canvasInformation.GetComponent<Canvas>().enabled = false;                        
    }

    // function to wait 3 seconds
    IEnumerator countThreeSeconds()
    {
        canvasMessageSaved.GetComponent<Canvas>().enabled = true; 
        yield return new WaitForSeconds(3);
        canvasMessageSaved.GetComponent<Canvas>().enabled = false;
    } 

    public Scenario GetObtainedScenario()
    {
        return obtainedScenario;
    }

    public Scenario[] GetObtainedScenarios()
    {
        return obtainedScenarios;
    }

    /******************** using Rest Client ********************/

    // Saves scenario information to the database
    public void Save()
    {                
        scenarioGameObject = GameObject.FindGameObjectWithTag("Scenario");
        scenarioName = scenarioGameObject.name;

        initialTime = initTime;
        finishTime = DateTime.Now;
        duration = finishTime.Subtract(initialTime);

        scenario = new Scenario();        
        // save in the firebase db with Put method
        RestClient.Put<Scenario>($"{database}scenarios/{userID}/{scenarioName} {date}-{initialTime.Hour}:{initialTime.Minute}:{initialTime.Second}.json", scenario);
        StartCoroutine(countThreeSeconds());
    }

    // 
    public static void Load(string scName)
    {                   
        // GET method to access to the database information        
        RestClient.Get<Scenario>($"{database}scenarios/{userID}/{scName}.json").Then(response => 
        {                                   
            obtainedScenario = response;            
        });                           
    }

    public static void LoadAll()
    {
        // GET method to access to the database information                    
        RestClient.Get($"{database}scenarios/{userID}.json").Then(response => 
        {                                   
            var res = response.Text;
            
            if (res != null){
                var values = Json.Deserialize<IDictionary<string, Scenario>>(res);
            
                obtainedScenarios = new Scenario[values.Count];
                int i = 0;
                foreach (var item in values)
                {                
                    obtainedScenarios[i] = item.Value;                
                    i++;
                    Debug.Log(item.Value.scenarioName);
                }
            } else if (res == null)
            {
                obtainedScenarios = null;  
            }                             
        });           
    }    

}
