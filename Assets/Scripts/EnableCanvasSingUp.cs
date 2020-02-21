using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCanvasSingUp : MonoBehaviour
{
    private Canvas canvasSignUp;
    // Start is called before the first frame update
    void Start()
    {
        canvasSignUp = GetComponent<Canvas>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            canvasSignUp.enabled = !canvasSignUp.enabled;
        }
    }
}
