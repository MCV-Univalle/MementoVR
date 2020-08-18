using System;
using Proyecto26; // Rest client
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserData: MonoBehaviour
{
    private User user = new User();
    private static User obtainedUser = new User();
    public static string name;
    public static string surname;    
    public static string birthday;
    public static string birthmonth;
    public static string birthyear;
    public static string birthdate;
    public static string id;

    public TMP_InputField inputName;
    public TMP_InputField inputSurname;    
    public TMP_InputField inputBirthday;
    public TMP_Dropdown inputBirthmonth;
    public TMP_InputField inputBirthyear;
    public TMP_InputField inputId;

    public Canvas canvasRegistered; 
    public Canvas canvasRequiredData; 
    public Canvas canvasDate; 

    private static string dbName = ""; // your firebase project id here
    private static string database = $"https://{dbName}.firebaseio.com/";

    void Start()
    {
        canvasRegistered.GetComponent<Canvas>().enabled = false; 
        canvasRequiredData.GetComponent<Canvas>().enabled = false;
        canvasDate.GetComponent<Canvas>().enabled = false;

        obtainedUser = new User();
    }

    // Adds a user to the database
    public void PostUser()
    {        
        name = inputName.text;
        surname = inputSurname.text;
        birthday = inputBirthday.text;
        birthmonth = inputBirthmonth.captionText.text;
        birthyear = inputBirthyear.text;
        birthdate = $"{birthday}/{birthmonth}/{birthyear}";
        id = inputId.text;

        // validate birthdate
        Boolean isDate = IsDate(birthdate);
        
        user = new User(); 
        if (name != "" && surname != "" && id != "")       
        {            
            if (!isDate)     
            {
                StartCoroutine(countThreeSeconds(canvasDate));
            } else 
            {
                RestClient.Put<User>($"{database}users/{user.id}.json", user).Then(response => {
                    StartCoroutine(countThreeSeconds(canvasRegistered));           
                });
            }
        } else if (name == "" || surname == "" || id == "")
        {
            StartCoroutine(countThreeSeconds(canvasRequiredData)); 
        }  
    }

    // Get the user with id = userId
    public static void GetUser(string userId)
    {             
        RestClient.Get<User>($"{database}users/{userId}.json").Then(response => {            
            obtainedUser = response;                                            
        });        
    }

    public User GetUserData()
    {
        return obtainedUser;
    }

    // function to show a message during 3 seconds
    IEnumerator countThreeSeconds(Canvas canvas)
    {         
        canvas.GetComponent<Canvas>().enabled = true; 
        yield return new WaitForSeconds(3);
        canvas.GetComponent<Canvas>().enabled = false;
    } 

    public static Boolean IsDate(string date)
    {       
        DateTime d;
        return DateTime.TryParse(date, out d);  
    }

}