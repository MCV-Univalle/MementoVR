using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera diningRoomCamera; 
    public Camera kitchenCamera; 
    public Camera bathroomCamera; 
    public Camera livingRoomRCamera; 
    public Camera livingRoomLCamera; 
    public Camera bedroomCamera; 
    public Button btn;

    void Start()
    {
        Button btn1 = btn.GetComponent<Button>();
        btn1.onClick.AddListener(Change);
    }

    private void Change() 
    {
        if (mainCamera.enabled)
        {
            mainCamera.enabled = false;
            diningRoomCamera.enabled = true;
            kitchenCamera.enabled = false;
            livingRoomRCamera.enabled = false; 
            bathroomCamera.enabled = false;
            livingRoomLCamera.enabled = false; 
            bedroomCamera.enabled = false;
        }
        else if (diningRoomCamera.enabled)
        {
            mainCamera.enabled = false;
            diningRoomCamera.enabled = false;            
            kitchenCamera.enabled = true; 
            livingRoomRCamera.enabled = false;
            bathroomCamera.enabled = false;
            livingRoomLCamera.enabled = false;
            bedroomCamera.enabled = false;
        }
        else if (kitchenCamera.enabled)
        {
            mainCamera.enabled = false;
            diningRoomCamera.enabled = false;
            kitchenCamera.enabled = false; 
            livingRoomRCamera.enabled = false;
            bathroomCamera.enabled = false;
            livingRoomLCamera.enabled = true;
            bedroomCamera.enabled = false;
        }
        else if (livingRoomLCamera.enabled)
        {
            mainCamera.enabled = false;
            diningRoomCamera.enabled = false;
            kitchenCamera.enabled = false; 
            livingRoomRCamera.enabled = true;
            bathroomCamera.enabled = false;
            livingRoomLCamera.enabled = false;
            bedroomCamera.enabled = false;
        }
        else if (livingRoomRCamera.enabled)
        {
            mainCamera.enabled = false;
            diningRoomCamera.enabled = false;
            kitchenCamera.enabled = false;
            livingRoomRCamera.enabled = false; 
            bathroomCamera.enabled = true;
            livingRoomLCamera.enabled = false;
            bedroomCamera.enabled = false;
        }
        else if (bathroomCamera.enabled)
        {
            mainCamera.enabled = false;
            diningRoomCamera.enabled = false;
            kitchenCamera.enabled = false;
            livingRoomRCamera.enabled = false; 
            bathroomCamera.enabled = false;
            livingRoomLCamera.enabled = false;
            bedroomCamera.enabled = true;
        }                 
        else
        {
            mainCamera.enabled = true;
            diningRoomCamera.enabled = false;
            kitchenCamera.enabled = false; 
            livingRoomRCamera.enabled = false;
            bathroomCamera.enabled = false;
            livingRoomLCamera.enabled = false;
            bedroomCamera.enabled = false;
        }
    }    
}
