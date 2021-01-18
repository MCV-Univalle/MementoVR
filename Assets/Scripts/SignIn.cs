using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class SignIn : MonoBehaviour
{
    public TMP_InputField inputId; 
    public TMP_InputField inputPassword;
    //public Button btn;
    //public Button BtnAccept;
    private Canvas canvasMessage; 
    private string id = "";
    private string password = "";   
    private static User user = new User(); 
    private UserData userdata = new UserData();

    // Start is called before the first frame update
    void Start()
    {   
        user = null;

        canvasMessage = GameObject.Find("Canvas").GetComponent<Canvas>();
        canvasMessage.GetComponent<Canvas>().enabled = false;
    }

    void Update() {
        id = inputId.text;
        password = inputPassword.text;

        if (inputId.isFocused && Input.GetKeyDown(KeyCode.Tab))
        {
            inputPassword.ActivateInputField();
        }  
        /*if (id == "1234" && password == "1234" && Input.GetKeyDown(KeyCode.Return))      
        {
            SceneManager.LoadScene("PantallaMenu");            
        }*/      
    }
    
    public void SetObtainedUser(User u)
    {
        user = u;
    }

    public User GetObtainedUser()
    {
        return user;
    }    

    private void OnGUI() 
    {
        Event e = Event.current;
        if (e.isKey)
        {
            UserData.GetUser(id);
        }                             
    }

    public void SignInFunction(Button btn)
    {                                       
        //UserData.GetUser(id);        
        SetObtainedUser(userdata.GetUserData());                
        
        if (id == user.id && password == user.id)
        {
            SceneManager.LoadScene("PantallaMenu");                
        }
        else if (id == "" || password == "" || id != password)
        {
            if (user.id == null || password == "")
            {
                canvasMessage.GetComponent<Canvas>().enabled = true;
            }            
            //if button accept is pressed
            if (btn.name == "BtnAccept")
            {
                canvasMessage.GetComponent<Canvas>().enabled = false;
            }
        }
    }
    
}
