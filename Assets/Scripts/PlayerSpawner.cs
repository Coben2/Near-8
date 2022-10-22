using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerSpawner : MonoBehaviour
{
    public GameObject player;
    public SpawnPoint[] spawnPoints;

    // Start is called before the first frame update
    //void Update()
    //{
    //    foreach (SpawnPoint point in spawnPoints)
    //    {
    //        if(point.spawnpointID == SpawnPoint.currentSpawnPointID)
    //        {
    //            Scene newScene = SceneManager.GetSceneByName("Extended Maze");
    //            SceneManager.MoveGameObjectToScene(point.gameObject, newScene);
                
    //            player.transform.position = point.transform.position;
    //            break;
    //        }
    //    }
    //}

}
