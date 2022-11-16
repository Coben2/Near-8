using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneAtVidEnd : MonoBehaviour
{
    public GameObject manager;
    public GameObject vidPanel;
    VideoPlayer video;
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 0;

        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        //SceneManager.LoadScene("editable Maze 2022 Copy");
        manager.SetActive(true);
        Time.timeScale = 1;
        vidPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
