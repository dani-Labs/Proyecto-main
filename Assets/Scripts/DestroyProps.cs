using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProps : MonoBehaviour
{
    [SerializeField] GameObject props;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        BoxDestroyable();
    }
    IEnumerator BoxDestroyable()
    {
        Debug.Log("Touched");
        Destroy(props);
        yield return null;

    }
}
