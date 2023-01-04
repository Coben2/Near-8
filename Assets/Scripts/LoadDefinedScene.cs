using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDefinedScene : MonoBehaviour
{
    public string ScenetoLoad;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadSceneAsync(ScenetoLoad);
    }

}
