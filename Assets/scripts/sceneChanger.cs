using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiaJuego()
    {
        SceneManager.LoadScene("juego");
    }


    public void cambiaMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
