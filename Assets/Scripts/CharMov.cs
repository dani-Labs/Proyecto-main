using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMov : MonoBehaviour
{
    float h, v;
    [SerializeField]float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v).normalized * speed, ForceMode.Force);
    }
}
