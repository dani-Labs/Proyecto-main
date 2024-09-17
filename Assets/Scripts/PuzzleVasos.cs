using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PuzzleVasos : MonoBehaviour
{
        
    [SerializeField] Camera camaraPuzzle;
     Vasos vasoOrigen;
     Vasos vasoDestino;
     Vasos vasoInteraccionActual;
     int contadorClicks;
     Animator huevo;
     [SerializeField] GameObject huevinchi;
     [SerializeField] GameObject llave;
    
    

        // Start is called before the first frame update
        void Start()
        {
        huevo = huevinchi.GetComponent<Animator>();
        
        }

        // Update is called once per frame
        void Update()
        {
            if (vasoDestino && vasoOrigen)
            {
                Debug.Log("Origen: " + vasoOrigen.gameObject.name);
                Debug.Log("Destino: " + vasoDestino.gameObject.name);

            }
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = camaraPuzzle.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    contadorClicks++;
                    if (contadorClicks % 2 != 0)
                    {
                        vasoOrigen = hit.transform.GetComponent<Vasos>();

                    }
                    else
                    {
                        vasoDestino = hit.transform.GetComponent<Vasos>();
                        Verter();
                    }

                }

            }

             if (vasoDestino.cantidadActual == 5 || vasoOrigen.cantidadActual == 5)
             {
               
               huevo.SetTrigger("romper");
               Debug.Log("Puzzle Resuelto");
               llave.SetActive(true);
               
             }
            

        }
        void Verter()
        {
            LimpiarVaso(vasoOrigen);
            LimpiarVaso(vasoDestino);

            //Quito del vaso de origen tantos huecos como rellene en el destino.
            int huecosDestino = vasoDestino.capacidadTotal - vasoDestino.cantidadActual;
             
             Debug.Log("huecos destino" + huecosDestino);


            if (vasoOrigen.cantidadActual <= huecosDestino )
            {
               huecosDestino = vasoOrigen.cantidadActual;
               vasoOrigen.cantidadActual = 0;
        }
            else
            {
             vasoOrigen.cantidadActual = vasoDestino.capacidadTotal - huecosDestino;

            }

        Debug.Log(" vaso origen cantActual" + vasoOrigen.cantidadActual);

            vasoDestino.cantidadActual = vasoDestino.cantidadActual + huecosDestino;
            if (vasoDestino.cantidadActual > vasoDestino.capacidadTotal)
            {
                vasoDestino.cantidadActual = vasoDestino.capacidadTotal;
            }


            LlenarVaso(vasoOrigen);
            LlenarVaso(vasoDestino);


        }

        void LimpiarVaso(Vasos vasoALimpiar)
        {
            Transform[] hijosVasoLimpiar = new Transform[vasoALimpiar.transform.childCount];
            for (int i = 0; i < hijosVasoLimpiar.Length; i++)
            {
                hijosVasoLimpiar[i] = vasoALimpiar.transform.GetChild(i);
                hijosVasoLimpiar[i].gameObject.SetActive(false);

            }
        }

        void LlenarVaso(Vasos vasoALlenar)
        {
            Transform[] hijosVaso = new Transform[vasoALlenar.transform.childCount];
            for (int i = 0; i < vasoALlenar.cantidadActual; i++)
            {
                hijosVaso[i] = vasoALlenar.transform.GetChild(i);
                hijosVaso[i].gameObject.SetActive(true);
            }

        }

    
}

