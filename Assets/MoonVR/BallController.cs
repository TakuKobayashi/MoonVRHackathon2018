using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed = 1000;

    private Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
        var movement = new Vector3(0, 0.3f, 2);
        
        rb.AddForce(movement * speed);

    }

    void Update()
    {
    }
}
