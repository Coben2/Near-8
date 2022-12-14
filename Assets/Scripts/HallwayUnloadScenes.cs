using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallwayUnloadScenes : MonoBehaviour
{
    public string PreviousScene1;
    public string PreviousScene2;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.UnloadSceneAsync(PreviousScene1);
        SceneManager.UnloadSceneAsync(PreviousScene2);
    }
}
