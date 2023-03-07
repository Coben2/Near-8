using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLookAt : MonoBehaviour
{
    LookAtCoroutine LookAt;
    Transform player;
    public float playerMoveTimer;
    public float lookAtDuration;
    private void OnTriggerEnter(Collider Col)
    {
        LookAt =  GetComponent<LookAtCoroutine>();
        //playerMoveTimer

        if (Col.gameObject.CompareTag("Player"))
        {
            LookAt.DoRotate();
        }
    }
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
