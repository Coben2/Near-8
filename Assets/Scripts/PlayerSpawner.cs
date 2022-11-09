using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerSpawner : MonoBehaviour
{
    public GameObject player;           //allows definition of a GameObject as "player"
    public SpawnPoint[] spawnPoints;    

    // Start is called before the first frame update
    void Update()
    {
       foreach (SpawnPoint point in spawnPoints)  //repeats code for each SpawnPoint variable within spawnPoints
       {
           if(point.spawnpointID == SpawnPoint.currentSpawnPointID)            //if spawnpointID is equal to currentSpawnPointID in SpawnPoint script,
           {
               Scene newScene = SceneManager.GetSceneByName("Extended Maze");       //set newScene to "Extended Maze" (which does not exist in current files)
               SceneManager.MoveGameObjectToScene(point.gameObject, newScene);      //moves a GameObject to the new scene
                
               player.transform.position = point.transform.position;                //set player's position to the position of point
               break;
            }
        }
    }

}
