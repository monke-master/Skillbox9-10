using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explose : MonoBehaviour
{

    public float power = 5f;
    public float radius = 20f;
    public float timeToBoom = 3;

    void Update()
    {
        timeToBoom -= Time.deltaTime;

        if (timeToBoom < 0)
        {
            Explosing();
            timeToBoom = 3;
        }
    }

    void Explosing()
    {
        Rigidbody[] objects = FindObjectsOfType<Rigidbody>();

        foreach (var obj in objects)
        {
            if (Vector3.Distance(obj.transform.position, transform.position) < radius)
            {
                Vector3 dir = obj.transform.position - transform.position;
                
                obj.AddForce(dir.normalized * power * (radius - Vector3.Distance(transform.position, obj.transform.position)));
            }
        }
    }
}
