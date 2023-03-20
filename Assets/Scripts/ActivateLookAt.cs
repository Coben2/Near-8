using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Micosmo.SensorToolkit;

public class ActivateLookAt : MonoBehaviour
{
    LookAtCoroutine LookAt;
    public Sensor TargetSensor;
    private bool seen;

    private void Start()
    {
        LookAt = GetComponent<LookAtCoroutine>();
        StartCoroutine(SeenRotate());

    }
    private void Update()
    {
        var target = TargetSensor.GetNearestDetection();
        if (target != null)
        {
            seen = true;
        }
        else
        {
            seen = false;
        }
    }
    IEnumerator SeenRotate()
    {
        while (seen == true)
        {
            LookAt.DoRotate();
            yield return new WaitForSeconds(3f);
        }
    }
    //Transform player;
    //public float playerMoveTimer;
    //public float lookAtDuration;
    //private void OnTriggerEnter(Collider Col)
    //{
    //    LookAt =  GetComponent<LookAtCoroutine>();
    //    //playerMoveTimer

    //    if (Col.gameObject.CompareTag("Player"))
    //    {
    //        LookAt.DoRotate();
    //    }
    //}
    //private void OnTriggerStay(Collider Col)
    //{
    //    if (Col.gameObject.CompareTag("Player"))
    //    {
    //        playerMoveTimer -= Time.deltaTime;
    //        lookAtDuration -= Time.deltaTime;
    //        player = GameObject.FindGameObjectWithTag("Player").transform;

    //        if (playerMoveTimer <= 0)
    //        {
    //            if (player != GameObject.FindGameObjectWithTag("Player").transform)
    //            {
    //                lookAtDuration = 10;
    //                playerMoveTimer = 15;
    //            }
    //        }
    //        if (lookAtDuration > 0)
    //        {
    //            LookAt.DoRotate();
    //        }
    //        if (lookAtDuration <= 0)
    //        {
    //            transform.eulerAngles = new Vector3(13, 0, 0);
    //        }
    //        playerMoveTimer = 10;
    //    }
    //}
}
