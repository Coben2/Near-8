using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRotation : MonoBehaviour
{
    // Your bounds
    private const float ROTATION_MIN = -23f;
    private const float ROTATION_MAX = 23f;

    // How much to rotate by
    public float rotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get our current rotation and update based on input
        Vector3 currentRotation = transform.eulerAngles;
        float inputInfluence = 0;

        // Apply the inputs
        //if (Input.GetKey(KeyCode.Q))
        //    inputInfluence += rotationSpeed;
        //if (Input.GetKey(KeyCode.E))
        //    inputInfluence -= rotationSpeed;

        // Account for multiples
        currentRotation.z = currentRotation.z % 360;

        // Then account for wrapping
        if (currentRotation.z > 180)
            currentRotation.z -= 360f;

        // Modify the rotation vector and reassign it
        currentRotation.z = Mathf.Clamp(currentRotation.z + inputInfluence, ROTATION_MIN, ROTATION_MAX);
        transform.rotation = Quaternion.Euler(currentRotation);
    }
}
