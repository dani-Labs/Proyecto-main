using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCaja : MonoBehaviour
{
    [SerializeField]Animator anim;
    [SerializeField]Animator animCaja;
    [SerializeField]Animator animPalanca;
    [SerializeField] GameObject props;
    [SerializeField] GameObject palanca;
    int contadorClicks;
    [SerializeField] GameObject cajinchi;
    //Collider collCajinchi;
   
    // Start is called before the first frame update
    void Start()
    {
        //collCajinchi = cajinchi.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("Box@Anim");
            QuitarObjetos();
            ContadorClicks();
            PoleaMethod();
        }
       
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
   

    void QuitarObjetos()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(props);
        }
    }
    //EthanRoute

    void ContadorClicks()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contadorClicks++;
            if (contadorClicks >= 7)
            {
                Destroy(cajinchi);
            }
        }
    }

    //NoraRoute
    void PoleaMethod()
    {
        if (contadorClicks >=3)
        {
            //Entrar�a el di�logo para avisar de la necesidad de una polea
            animPalanca.SetBool("MovPalanca", true);
            if (animCaja==true)
            {
                palanca.SetActive(false);
                animCaja.SetBool("MoverCaja", true);
            }
            //Se necesitar�a una animaci�n del movimiento de la caja con una palanca
            cajinchi.transform.Translate(new Vector3());
        }
    }
}
