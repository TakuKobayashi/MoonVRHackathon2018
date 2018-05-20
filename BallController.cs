using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed = 1000; // 動く速さ

    private Rigidbody rb; // Rididbody

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
