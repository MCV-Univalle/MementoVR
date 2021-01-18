using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] // This makes the class able to be serialized into a JSON
public class User
{
    public string name;
    public string surname;
    public string birthday;
    public string birthmonth;
    public string birthyear;
    public string id;

    public User()
    {
        name = UserData.name;
        surname = UserData.surname;        
        birthday = UserData.birthday;
        birthmonth = UserData.birthmonth;
        birthyear = UserData.birthyear;
        id = UserData.id;
    }

}
