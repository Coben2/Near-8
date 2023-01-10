using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Computes the angle between the White Room transform and this object

public class faceWhiteRoom : MonoBehaviour
{
    private float angleBtwn;
    public Transform target;

    private void Start()
    {
        Vector3 targetDir = target.position - transform.position;
        angleBtwn = Vector3.Angle(transform.forward, targetDir);
    }
}
