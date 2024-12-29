using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    float z = 0f;
    float x = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(x, rb.velocity.y, z);
        if(Input.GetKeyDown(KeyCode.W))
        {
            z = 4f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            z = -4f;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            x = 4f;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            x = -4f;
        }

        if(Input.GetKeyUp(KeyCode.A)) {
            x = 0f;
        }
    }
}
