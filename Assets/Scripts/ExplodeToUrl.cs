using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ExplodeToUrl : MonoBehaviour
{

    public GameObject vidPanel;
    VideoPlayer video;
    public string url;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        //SceneManager.LoadScene("editable Maze 2022 Copy");
        Application.OpenURL(url);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
