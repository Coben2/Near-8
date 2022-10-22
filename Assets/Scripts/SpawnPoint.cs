using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnPoint : MonoBehaviour
{
    public static int currentSpawnPointID;
    public int spawnpointID;
  
    private void OnTriggerEnter(Collider other)
    {
        currentSpawnPointID = spawnpointID;

        Debug.Log(currentSpawnPointID);
    }

}
