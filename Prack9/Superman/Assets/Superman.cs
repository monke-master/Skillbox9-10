using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{

    public float speed = 5f;
    public float power = 5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector3.right * speed;
    }

    private void OnCollisionEnter(Collision other)
    {
        var rigidBody = other.gameObject.GetComponent<Rigidbody>();
        if (rigidBody != null)
        {
            Vector3 direction = other.transform.position - transform.position;
            
            rigidBody.AddForce(direction.normalized * power);
        }
    }
}
