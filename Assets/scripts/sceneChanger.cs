using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChanger : MonoBehaviour
{
    public void cambiaJuego()
    {
        SceneManager.LoadScene("juego");
    }


    public void cambiaMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
