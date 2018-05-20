using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private float speed = 1000f;
    private bool isShoot = false;
    private bool isCollapse = false;

    private Rigidbody rb;
    [SerializeField] FracturedObject mountain;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(this.transform.localPosition.z >= 50f){
            if(!isCollapse){
                mountain.CollapseChunks();
                isCollapse = true;
            }
        }
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
