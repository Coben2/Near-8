using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnPoint : MonoBehaviour
{
    public static int currentSpawnPointID;      //defines a static int "currentSpawnPointID
    public int spawnpointID;                    //allows definition of integer "spawnpointID"

    private void OnTriggerEnter(Collider other)     //calls OnTriggerEnter when an "other" Collider enters the trigger
    {
        currentSpawnPointID = spawnpointID;         //sets the currentSpawnPointID to the spawnpointID of the point the script is on

        Debug.Log(currentSpawnPointID);             //sends message in debug log saying the currentSpawnPointID
    }

}
