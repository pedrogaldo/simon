using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rojo : MonoBehaviour
{
    private SpriteRenderer theSprite;
    public int numTambor;


    private GameManager theGM;

    private AudioSource elSonido;
    // Start is called before the first frame update
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        theGM = FindObjectOfType<GameManager>();
        elSonido = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Q))
        {
            theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1f);
            elSonido.Play();
        }


        else if (Input.GetKey(KeyCode.W))
        {

        }

        else if (Input.GetKey(KeyCode.E))
        {

        }

        else if (Input.GetKey(KeyCode.R))
        {

        }

        else if (Input.GetKey(KeyCode.T))
        {

        }

        else if (Input.GetKey(KeyCode.A))
        {


        }

        else if (Input.GetKey(KeyCode.S))
        {


        }

        else if (Input.GetKey(KeyCode.D))

        {

        }

        else if (Input.GetKey(KeyCode.F))
        {

        }

        else if (Input.GetKey(KeyCode.G))
        {

        }

        else if (Input.GetKey(KeyCode.Z))
        {

        }

        else if (Input.GetKey(KeyCode.X))
        {

        }

        else if (Input.GetKey(KeyCode.C))
        {

        }

        else if (Input.GetKey(KeyCode.V))
        {

        }

        else if (Input.GetKey(KeyCode.B))
        {

        }

        else
        {

        }
    }
}
