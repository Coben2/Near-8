using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MUST HAVE Ball Gyro (Script) [on Ball] DEACTIVATED

public class RotateCamMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float Speed = 5;     //defaults speed to 5 and allows for ajustment in inspector

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))                        //if left mouse button is pressed,
        {

            transform.eulerAngles += Speed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);   //make camera follow mouse pointer

            //transform.Rotate(transform.up ,-Input.GetAxis("Mouse X") * Speed  ); //1
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
