using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
   [SerializeField] Camera MainCamera;
   [SerializeField] LayerMask Interactuable;
   Vector3 PosicionRaton;
    
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Zoom();
        }
    }

    void Zoom()
    {
        if ( Interactuable != null)
        {
          gameObject.SetActive(true);
          MainCamera.gameObject.SetActive(false);

            //Input.mousePosition
        }
    }
}
