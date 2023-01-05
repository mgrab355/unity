using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4 : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right);
        }

    }
}
