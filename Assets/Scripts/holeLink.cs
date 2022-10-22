using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class holeLink : MonoBehaviour
{
    // Start is called before the first frame update

    public string url;

    public void OnTriggerEnter()
    {
        Application.OpenURL(url);
        SceneManager.LoadScene("Aspect-Ratio");
    }
}
