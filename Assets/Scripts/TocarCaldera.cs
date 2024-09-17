using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarCaldera : MonoBehaviour
{
    public float rotate = 40;
    public int digit;
    [SerializeField] public int correctDigit;
    Coroutine call;
    float targetDegree = 0;
    float currentDegrees = 0;

    bool onZoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (digit >= 10)
        {
            digit = 0;
        }
    }

    private void OnMouseDown()
    {
        if (call == null)
        {
            call = StartCoroutine(RotateDigit());
        }
    }

    IEnumerator RotateDigit()
    {
        Quaternion initRotation = Quaternion.Euler(new Vector3(currentDegrees, transform.rotation.y, transform.rotation.z));
        targetDegree = currentDegrees - 40;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(targetDegree, transform.rotation.y, transform.rotation.z));
        float timer = 0;
        float spinTime = 1f;
        digit++;
        Debug.Log(digit);

        while (timer <= spinTime)
        {
            Quaternion interpolated = Quaternion.Slerp(initRotation, targetRotation, timer / spinTime);
            transform.rotation = interpolated;
            timer += Time.deltaTime;
            yield return null;
        }
        transform.rotation = targetRotation;
        currentDegrees = targetDegree;

        call = null;
    }
}
