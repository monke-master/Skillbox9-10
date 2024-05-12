using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerScript : MonoBehaviour
{

    public float power = 50f;
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            Vector3 direction = other.transform.position - transform.position;
            other.gameObject.GetComponent<Rigidbody>().AddForce(power*direction.normalized, ForceMode.Force);
        }
    }
}
