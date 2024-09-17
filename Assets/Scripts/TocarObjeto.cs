using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TocarObjeto : MonoBehaviour
{
    bool inZoom;
    [SerializeField] Camera zombieCam;
    [SerializeField] CinemachineVirtualCamera mainCam;
    [SerializeField] CinemachineVirtualCamera zoomCam;
    CinemachineBrain brain;
    [SerializeField] WallMov wallMov;

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
        //wallMov.enabled = false;
        
    }

    private void Update()
    {
        if(inZoom && Input.GetKeyDown(KeyCode.Backspace))
        {
            mainCam.gameObject.SetActive(true);
            zoomCam.gameObject.SetActive(false);
            inZoom = false;
            wallMov.enabled = true;
        }
        else
        if(!inZoom && !brain.IsBlending)
        {
            //zombieCam.orthographic = true;
        }
        //if (Input.GetKeyDown(KeyCode.Clear))
        //{
        // Interactuable = false;
        //    Debug.Log("ZoomOut");
        //}

        //if (Interactuable == true && Input.GetMouseButtonDown (0))
        //{
        //    MainCamera.enabled = true;
        //    ZoomCamera.enabled = false;
        //    Debug.Log("ZoomIn");
        //}

        //if (Interactuable == false)
        //{
        //    MainCamera.enabled = true;
        //    ZoomCamera.enabled = false;
        //}
    }
}
