using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevo : MonoBehaviour
{
    public int contClicks;
    [SerializeField] GameObject huevoSaco;
    [SerializeField] GameObject huevoLavabo;
    [SerializeField] GameObject zoom;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(contClicks);
    }

    private void OnMouseDown()
    {
        contClicks++;
        if (contClicks >= 2&& zoom.activeSelf==true)
        {
            Destroy(huevoSaco);
            huevoLavabo.SetActive(true);
        }
    }
}
