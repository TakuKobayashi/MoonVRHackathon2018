using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private float speed = 1000f;
    private bool isShoot = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    }

    public void Shoot(){
        if(isShoot){
            return;
        }
        var movement = new Vector3(0, 0.25f, 1);
        rb.AddForce(movement * speed);
        isShoot = true;
    }
}
