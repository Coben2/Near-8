using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalLoadScene : MonoBehaviour
{
    public string LoadScene;

    public void OnTriggerEnter()
    {
        Debug.Log("trigger entered");
        SceneManager.LoadScene(LoadScene);
        Debug.Log("loaded scene");
    }
}
