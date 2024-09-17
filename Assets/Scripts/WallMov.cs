using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMov : MonoBehaviour
{
    Coroutine llamada;
    [SerializeField] GameObject[] paredes;
    [SerializeField] GameObject[] objParedes;

    MeshRenderer[] ao;
    int view;
    // Start is called before the first frame update
    void Start()
    {
        ao = new MeshRenderer[paredes.Length];
        for (int i = 0; i < paredes.Length; i++)
        {
            ao[i] = paredes[i].GetComponent<MeshRenderer>();
        }
        ao[0].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        ao[1].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        objParedes[0].SetActive(false);
        objParedes[1].SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (llamada == null)
            {
                CambiarParedes();
                llamada = StartCoroutine(RotarCamara());
            }
        }
    }
    IEnumerator RotarCamara()
    {
        Quaternion rotacionActual = transform.rotation;
        Quaternion rotacionObjetivo = Quaternion.Euler(transform.eulerAngles + new Vector3(0, -90, 0));
        float timer = 0;
        float tiempoDeGiro = 1f;
        while (timer <= tiempoDeGiro)
        {
            Quaternion rotacionInterpolada = Quaternion.Slerp(rotacionActual, rotacionObjetivo, timer / tiempoDeGiro);
            transform.rotation = rotacionInterpolada;
            timer += Time.deltaTime;
            yield return null;
        }
        transform.rotation = rotacionObjetivo;
        llamada = null;
    }

    void CambiarParedes()
    {
        view++;
        if (view == 1)
        {
            ao[0].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[3].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[1].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            ao[2].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            objParedes[1].SetActive(false);
            objParedes[2].SetActive(false);
            objParedes[3].SetActive(true);
            objParedes[0].SetActive(true);



        }
        else if (view == 2)
        {
            ao[0].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[1].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[2].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            ao[3].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            objParedes[2].SetActive(false);
            objParedes[3].SetActive(false);
            objParedes[1].SetActive(true);
            objParedes[0].SetActive(true);
        }
        else if (view == 3)
        {
            ao[1].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[2].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[3].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            ao[0].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            objParedes[3].SetActive(false);
            objParedes[0].SetActive(false);
            objParedes[1].SetActive(true);
            objParedes[2].SetActive(true);
        }
        else
        {
            ao[2].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[3].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            ao[0].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            ao[1].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            objParedes[0].SetActive(false);
            objParedes[1].SetActive(false);
            objParedes[2].SetActive(true);
            objParedes[3].SetActive(true);
            view = 0;
        }
    }
}
