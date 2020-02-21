using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class ScenarioData
{
    // array with name of the objects
    private string[] nameObjs;
    // array with positions x,y,z 
    private float[] position = new float[3] {0,0,0};
    private float[,] positions = new float[100,3];    
    //acceder a x,y,z y guardar las pos en un arreglo de arreglos
    private DateTime init;
    private DateTime finish;

    public ScenarioData(Scenario sc)
    {    
        init = sc.initTime;
        finish = sc.finishTime;
        Debug.Log("init " + init);
        Debug.Log("finish " + finish);
        
        for (int i = 0; i < sc.objects.Length; i++)
        {
            nameObjs = new string[sc.objects.Length];
            nameObjs[i] = sc.objects[i].name;            
            Debug.Log(nameObjs[i]);
            position[0] = sc.objects[i].transform.position.x;
            position[1] = sc.objects[i].transform.position.y;
            position[2] = sc.objects[i].transform.position.z;            
            //Debug.Log(position);            
            positions[i,0] = position[0];
            positions[i,1] = position[1];
            positions[i,2] = position[2];          
        }
    }
    
}
