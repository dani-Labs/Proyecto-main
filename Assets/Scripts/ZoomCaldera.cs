using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomCaldera : MonoBehaviour
{
    bool inZoom;
    [SerializeField] Camera zombieCam;
    [SerializeField] CinemachineVirtualCamera mainCam;
    [SerializeField] CinemachineVirtualCamera zoomCam;
    CinemachineBrain brain;
    [SerializeField] WallMov wallMov;
    Collider coll;

    private void Start()
    {
        brain = zombieCam.gameObject.GetComponent<CinemachineBrain>();
        coll = GetComponent<Collider>();

    }
    private void OnMouseDown()
    {
        Debug.Log("T0cado");
        //zombieCam.orthographic = false; //Quitamos ortográfico y ponemos perspectiva,.
        mainCam.gameObject.SetActive(false);
        zoomCam.gameObject.SetActive(true);
        inZoom = true;
        wallMov.enabled = false;
        coll.enabled = false;

    }

    private void Update()
    {
        if (inZoom && Input.GetKeyDown(KeyCode.Backspace))
        {
            mainCam.gameObject.SetActive(true);
            zoomCam.gameObject.SetActive(false);
            inZoom = false;
            wallMov.enabled = true;
            coll.enabled = true;
        }
        else
        if (!inZoom && !brain.IsBlending)
        {
            //zombieCam.orthographic = true;
        }
    }
}
