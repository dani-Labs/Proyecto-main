using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EntreSalas : MonoBehaviour
{
    [SerializeField] GameObject salaOne;
    [SerializeField] GameObject salaTwo;
    [SerializeField] GameObject puntoUno;
    [SerializeField] GameObject puntoDos;
    


    bool CambioDeSala;
    // Start is called before the first frame update
    void Start()
    {
        salaTwo.SetActive(false);
        puntoDos.SetActive(false);

    }

    private void OnMouseDown()
    {
        Debug.Log("Paso de sala");
        CambioDeSala = true;
    }


    // Update is called once per frame
    void Update()
    {
        if ( CambioDeSala )
        {
            if (salaTwo.activeSelf == false)
            {
                salaTwo.SetActive(true);
                salaOne.SetActive(false);
            }
            else
            {
                salaTwo.SetActive(false);
                salaOne.SetActive(true);
            }

            MovimientoCamara();
            Debug.Log("DesapareceSala");
            CambioDeSala = false;
        }
    }

    void MovimientoCamara()
    {
        if (puntoDos.activeSelf == false)
        {
            puntoDos.SetActive(true);
            puntoUno.SetActive(false);

            Debug.Log("Estamos en la sala dos");
        }
        else
        {
            puntoDos.SetActive(false);
            puntoUno.SetActive(true);

            

            Debug.Log("Estamos en la sala uno");

        }


    }

    }


