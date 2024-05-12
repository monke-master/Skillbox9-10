using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravity : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var rigidBody = other.GetComponent<Rigidbody>();
        if (rigidBody != null)
        {
            rigidBody.useGravity = false;
            Debug.Log("NO GRAVITY");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var rigidBody = other.GetComponent<Rigidbody>();
        if (rigidBody != null)
        {
            rigidBody.useGravity = true;
            Debug.Log("YES GRAVITY");
        }
    }
}
