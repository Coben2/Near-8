using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoletoScene : MonoBehaviour
{
    public string gotoScene;
    public int sceneNumber;
    public string sceneName;

    public void OnTriggerEnter()
    {
        // Debug.Log("trigger entered");
        Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
        //Indestructable.instance.prevScene = Application.loadedLevel;
        Indestructable.instance.prevSceneName = sceneName;
        //Application.LoadLevel(sceneNumber);

        SceneManager.LoadSceneAsync(gotoScene);

        //  Debug.Log("loaded scene");
    }
}
