using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SignIn : MonoBehaviour
{
    public TMP_InputField inputId; 
    public TMP_InputField inputPassword;
    //public Button btn;
    //public Button BtnAccept;
    private Canvas canvasMessage; 
    private string id = "";
    private string password = "";


    // Start is called before the first frame update
    void Start()
    {   
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

        if (id == "1234" && password == "1234" && Input.GetKeyDown(KeyCode.Return))      
        {
            SceneManager.LoadScene("PantallaMenu");
        }       
    }
    
    public void SignInFunction(Button btn)
    {        
        if (id == "1234" && password == "1234")
        {
            SceneManager.LoadScene("PantallaMenu");                
        }
        else
        {
            canvasMessage.GetComponent<Canvas>().enabled = true;
            //if button accept is pressed
            if (btn.name == "BtnAccept")
            {
                canvasMessage.GetComponent<Canvas>().enabled = false;
            }
        }
    }
    
}
