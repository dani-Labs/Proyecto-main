using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class HojasCorcho : MonoBehaviour
{
    [SerializeField] GameObject canvaPaper;
    [SerializeField] CinemachineVirtualCamera currentZoom;
    // Start is called before the first frame update
    void Start()
    {
        //canvaPaper.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canvaPaper.activeSelf == true && currentZoom.isActiveAndEnabled && Input.GetKeyDown(KeyCode.Escape))
        {
            canvaPaper.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        if (currentZoom.isActiveAndEnabled)
        {
            Debug.Log("hoja tocada");
            canvaPaper.SetActive(true);
        }

    }
}
