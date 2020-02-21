using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SelectObject : MonoBehaviour
{
    private const string tag = "Seleccion";    
    public Material highlight;
    //public Material debugMaterial;
    //[SerializeField] private Material defaultMaterial;    
    //private Transform selection;
    private GameObject currentObject = null;    
    private GameObject obj;
    private GameObject[] objs;
    private Material[] mats = new Material[100];
    private Material materialsOfLastSelectedObject = null;
    private string name = "";

    public Vector3 posicionCanvas;

    // Update is called once per frame
    void Update()
    {                              
        ReturnGameObject();               
    }

    /**
     * Verifica que el click ocurra dentro del panel
     * mientras esta habilitado.
     */
    public bool isClickInsidePanelConfiguration(float clickX, float clickY) {
        Vector3 panelPivot = this.getPanelConfigurationPivot();
        return (clickX >= panelPivot.x && clickY >= panelPivot.y )
            && GameObject.FindGameObjectWithTag("PanelConfiguracion").GetComponent<Canvas>().enabled;
    }

    /**
     * Obtiene el pivote del panel de configuracion.
     * Nota: El pivote debe configurarse en la esquina inferior izquierda.
     */
    public Vector3 getPanelConfigurationPivot() {
        Canvas panelConfiguracion = GameObject.FindGameObjectWithTag("PanelConfiguracion").GetComponent<Canvas>();
        RectTransform rectTransformPanelConfiguracion = panelConfiguracion.GetComponent<RectTransform>();
        this.posicionCanvas = rectTransformPanelConfiguracion.position;
        return this.posicionCanvas;
    }

    public string ReturnGameObject()
    {            
        /*if (selection != null) 
        {                                                      
            for (int i = 0; i < objs.Length; i++)
            {
                if (name == objs[i].name)
                {                  
                    selection.GetComponent<Renderer>().material = mats[i];                    
                }                
            } 
            selection = null;            
        }*/
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;                

        if (Physics.Raycast(ray, out hit))         
        {   
            if (Input.GetMouseButtonDown(0) && !this.isClickInsidePanelConfiguration(Input.mousePosition.x,Input.mousePosition.y))
            {        

                /*if (this.isClickInsidePanelConfiguration(Input.mousePosition.x,Input.mousePosition.y) == true)
                {
                    Debug.Log("Click adentro");
                }*/

                var sel = hit.transform;                         
                if (sel.CompareTag(tag))
                {                                
                    obj = hit.collider.gameObject;
                    name = obj.name;                                                                                
                    //selection = sel;

                    /* if (this.currentObject != null && this.currentObject.name == obj.name) {
                        Debug.Log("Mismo objeto!!! "+obj.name);
                    } */                    
                    // TODO: Porque intenta reasignar un default material en un mismo frame?
                    // Workaround: Ignorar el material Default-Material (Instance)
                    if (this.currentObject != null && this.materialsOfLastSelectedObject != null 
                        && this.materialsOfLastSelectedObject.name != "Default-Material (Instance)") {
                        
                        this.currentObject.GetComponent<Renderer>().material = this.materialsOfLastSelectedObject;
                        
                        this.materialsOfLastSelectedObject = null;
                        this.currentObject = null;
                    }

                    this.currentObject = obj;
                    //SetGameobject(obj);
                                      
                    if (obj.GetComponent<Renderer>() != null)
                    {                                                
                        this.materialsOfLastSelectedObject = obj.GetComponent<Renderer>().material;

                        //Debug.Log("Materiales "+this.materialsOfLastSelectedObject);

                        //Material[] intMaterials = new Material[obj.GetComponent<Renderer>().materials.Length];
                        //for(int i = 0; i < intMaterials.Length; i++) {
                            //intMaterials[i] = highlight;
                        //}

                        currentObject.GetComponent<Renderer>().material = highlight;
                    }                     
                    return name;                
                }
            }
        } 
        return "";
    }

    public void SetGameobject(GameObject currentObjects){
        this.currentObject = currentObjects; 
    }

    public GameObject GetGameobject(){
        return this.currentObject; 
    }
}
