using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private float speed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        var movement = new Vector3(0, 0.5f, 1);
        
        rb.AddForce(movement * speed);

    }

    void Update()
    {
    }
}
