using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public SpriteRenderer[] tambores;

    private int tamborSelect;

    public float stayLit;
    private float staylitCounter;

    public float esperaEntreLuces;
    private float esperaLucesCounter;

    private bool shouldBeLit;
    private bool shouldBeDark;

    public List<int> activeSequence;
    private int positionInSequence;

    private bool gameActive = false;
    private int inputInSequence;

    public AudioSource correct;
    public AudioSource[] sonidoSecuencia;

    public GameObject canvas_GameOver;
    public GameObject btn_empezar;
    public GameObject tambores_pantalla;

    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        canvas_GameOver.SetActive(false);
        tambores_pantalla.SetActive(true);

        score.text = "Puntaje: 0, Mejor: " + PlayerPrefs.GetInt("HiScore");
        if (!PlayerPrefs.HasKey("HiScore"))
        {
            PlayerPrefs.SetInt("HiScore", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldBeLit)
        {
            staylitCounter -= Time.deltaTime;

            if (staylitCounter<0)
            {
                tambores[activeSequence[positionInSequence]].color = new Color(tambores[activeSequence[positionInSequence]].color.r, tambores[activeSequence[positionInSequence]].color.g, tambores[activeSequence[positionInSequence]].color.b, 0.5f);
                shouldBeLit = false;
                shouldBeDark = true;
                esperaLucesCounter = esperaEntreLuces;
                sonidoSecuencia[activeSequence[positionInSequence]].Stop();



                positionInSequence++;
            }

        }

        if (shouldBeDark)
        {
            esperaLucesCounter -= Time.deltaTime;

            if (positionInSequence >= activeSequence.Count)
            {
                shouldBeDark = false;
                gameActive = true;
            }
            else
            {
                if (esperaLucesCounter < 0)
                {
    

                    tambores[activeSequence[positionInSequence]].color = new Color(tambores[activeSequence[positionInSequence]].color.r, tambores[activeSequence[positionInSequence]].color.g, tambores[activeSequence[positionInSequence]].color.b, 1f);

                    sonidoSecuencia[activeSequence[positionInSequence]].Play();

                    staylitCounter = stayLit;
                    shouldBeLit = true;
                    shouldBeDark = false;

                }
            } 
        }
    }

    public void StartGame()
    {

        activeSequence.Clear();
        positionInSequence = 0;
        inputInSequence = 0;


        tamborSelect = Random.Range(0, tambores.Length);

        activeSequence.Add(tamborSelect);
         
        tambores[activeSequence[positionInSequence]].color = new Color(tambores[activeSequence[positionInSequence]].color.r, tambores[activeSequence[positionInSequence]].color.g, tambores[activeSequence[positionInSequence]].color.b, 1f);

        sonidoSecuencia[activeSequence[positionInSequence]].Play();

        staylitCounter = stayLit;
        shouldBeLit = true;

        score.text = "Puntaje: 0 \n Mejor: " + PlayerPrefs.GetInt("HiScore");

    }

    public void tamborPresionado(int whichButton)
    {

        if (gameActive)
        {
            if (activeSequence[inputInSequence] == whichButton)
            {
                Debug.Log("correcto");
                inputInSequence++;

                if(inputInSequence>= activeSequence.Count)
                {
                    if (activeSequence.Count > PlayerPrefs.GetInt("HiScore"))
                    {
                        PlayerPrefs.SetInt("Hiscore", activeSequence.Count);
                    }
                    score.text = "Puntaje: " + activeSequence.Count + " - Mejor: " + PlayerPrefs.GetInt("HiScore");

                    positionInSequence = 0;
                    inputInSequence = 0;

                    tamborSelect = Random.Range(0, tambores.Length);

                    activeSequence.Add(tamborSelect);

                    tambores[activeSequence[positionInSequence]].color = new Color(tambores[activeSequence[positionInSequence]].color.r, tambores[activeSequence[positionInSequence]].color.g, tambores[activeSequence[positionInSequence]].color.b, 1f);

                    sonidoSecuencia[activeSequence[positionInSequence]].Play();

                    staylitCounter = stayLit;
                    shouldBeLit = true;

                    gameActive = false;

                    correct.Play();

                }
                canvas_GameOver.SetActive(false);
                btn_empezar.SetActive(false);

            }

            else
            {
                Debug.Log("incorrecto");
                gameActive = false;
                canvas_GameOver.SetActive(true);
                tambores_pantalla.SetActive(false);
            }
        }

    }

    public void vuelveJuego()
    {
        tambores_pantalla.SetActive(true);
        canvas_GameOver.SetActive(false);
    }






}
