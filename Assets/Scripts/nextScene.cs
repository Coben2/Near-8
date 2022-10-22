using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextScene : MonoBehaviour
{
    public float time;
    public RawImage rIMage;
    // Start is called before the first frame update
    void Start()
    {
        time = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            SceneManager.LoadScene("Recording");
        }
    }
}
