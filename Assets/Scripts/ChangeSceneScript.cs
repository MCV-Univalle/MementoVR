using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneScript : MonoBehaviour
{
    private Canvas canvasMessageLoading;  

    private SignIn signin = new SignIn();
    private User user = new User();

    void Start()
    {
        user = signin.GetObtainedUser(); // logged in user
        
        canvasMessageLoading = GameObject.Find("CanvasLoading").GetComponent<Canvas>(); 
        canvasMessageLoading.GetComponent<Canvas>().enabled = false;      
    }

    public void ChangeScene(string sceneName)
    {        
        SceneManager.LoadScene(sceneName); 
        canvasMessageLoading.GetComponent<Canvas>().enabled = true;  
        
        if (sceneName == "PantallaInicioSesion")      
        {
            user = null;           
        }
    }    
}
