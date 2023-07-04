using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio_a_controles : MonoBehaviour
{

    public GameObject canvasMenu;
    public GameObject canvasControls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void cambioMain()
    {
        canvasMenu.SetActive(true);
        canvasControls.SetActive(false);
    }

    public void cambioControles()
    {
        canvasMenu.SetActive(false);
        canvasControls.SetActive(true);
    }

}
