using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoletoScene : MonoBehaviour
{
    public string gotoScene;

    public void OnTriggerEnter()
    {
       // Debug.Log("trigger entered");
        SceneManager.LoadSceneAsync(gotoScene);
      //  Debug.Log("loaded scene");
    }
}
