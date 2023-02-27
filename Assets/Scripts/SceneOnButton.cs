using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOnButton : MonoBehaviour
{
    public GameObject loading;

    public string Scene;
    public void LoadScene()
    {
        SceneManager.LoadScene(Scene);
        loading.SetActive(true);
    }
}
