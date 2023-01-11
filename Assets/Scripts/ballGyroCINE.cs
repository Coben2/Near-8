using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGyroCINE : MonoBehaviour
{
    //public Camera groundCam;
    public Movement1stPerson gManage;
    public Movement1stPersonIntroMaze gManageMaze;

    public Quaternion currentRotation;
    public float timer = 2f;

    Vector3 dir = Vector3.zero;
    public float Speed;

    public Rigidbody rigid;
    public float backSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        backSpeed = .4f;
    }

    // Update is called once per frame
    void Update()
    {
        //groundCam.transform.rotation = transform.rotation;
        //    Debug.Log(Input.gyro.attitude);
        dir = Input.acceleration;

        if (gManageMaze.Cam2active == true)
        {

            rigid.constraints = RigidbodyConstraints.FreezeRotation;
            rigid.velocity = Vector3.zero;




            if (Input.acceleration.z <= -.4f)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Speed);

            }
            if (Input.acceleration.z >= .1)
            {
                transform.Translate(Vector3.back * Time.deltaTime * Speed);

            }

        }
        else
        {
            rigid.constraints = RigidbodyConstraints.None;


        }

        if (gManageMaze.gameState == 3)
        {
            rigid.velocity = Vector3.zero;
        }

        if (gManage.Cam2active == true)
        {

            rigid.constraints = RigidbodyConstraints.FreezeRotation;
            rigid.velocity = Vector3.zero;




            if (Input.acceleration.z <= -.4f)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Speed);

            }
            if (Input.acceleration.z >= .1)
            {
                transform.Translate(Vector3.back * Time.deltaTime * Speed);

            }

        }
        else
        {
            rigid.constraints = RigidbodyConstraints.None;


        }

        if (gManage.gameState == 3)
        {
            rigid.velocity = Vector3.zero;
        }




    }
}
