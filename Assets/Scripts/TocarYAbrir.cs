using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TocarYAbrir : MonoBehaviour
{
    bool inZoom;
    [SerializeField] Camera zombieCam;
    [SerializeField] CinemachineVirtualCamera mainCam;
    [SerializeField] CinemachineVirtualCamera zoomCam;
    CinemachineBrain brain;
    [SerializeField] Transform objeto1;
    [SerializeField] Transform objeto2;
    

    private void Start()
    {
        brain = zombieCam.gameObject.GetComponent<CinemachineBrain>();

    }
    private void OnMouseDown()
    {
        Debug.Log("T0cado");
        //zombieCam.orthographic = false; //Quitamos ortográfico y ponemos perspectiva,.
        mainCam.gameObject.SetActive(false);
        zoomCam.gameObject.SetActive(true);
        inZoom = true;
        objeto1.eulerAngles = new Vector3(0, -170, 0);
        objeto2.eulerAngles = new Vector3(0, -170, 0);

    }

    private void Update()
    {
        if (inZoom && Input.GetKeyDown(KeyCode.Backspace))
        {
            mainCam.gameObject.SetActive(true);
            zoomCam.gameObject.SetActive(false);
            inZoom = false;
            objeto1.eulerAngles = new Vector3(0, -12, 0);
            objeto2.eulerAngles = new Vector3(0, -12, 0);

        }
        if (!inZoom && !brain.IsBlending)
        {
            //zombieCam.orthographic = true;
        }
    }

}
