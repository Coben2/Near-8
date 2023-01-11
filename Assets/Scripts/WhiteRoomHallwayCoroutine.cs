using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteRoomHallwayCoroutine : MonoBehaviour
{
    public GameObject ExitWhiteRoomHolder;

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");
        StartCoroutine(ExitWhiteRoomHolder.GetComponent<ExitWhiteRoom>().HallwayPress());
    }
}
