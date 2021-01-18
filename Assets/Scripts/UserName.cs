using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserName : MonoBehaviour
{
    public TextMeshProUGUI textName; 

    private SignIn signin = new SignIn();
    private User user = new User();

    void Start()
    {
        user = signin.GetObtainedUser(); // logged in user
        // set user's name on the GUI
        textName.SetText($"{user.name} {user.surname}");        
    }     
}
