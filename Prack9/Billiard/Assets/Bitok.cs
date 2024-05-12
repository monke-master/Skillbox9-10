using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitok : MonoBehaviour
{
    public float power = 50f;

    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(power * Vector3.right, ForceMode.Impulse);
    }
}
