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
    public string nextScene;

    void Awake()
    {
        StartCoroutine(vibe());
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadSceneAsync(nextScene);
        //Application.OpenURL(url);
    }
    // Update is called once per frame
    IEnumerator vibe()
    {
        Handheld.Vibrate();
        yield return new WaitForSeconds(0.1f);
        Handheld.Vibrate();
        yield return new WaitForSeconds(0.1f);
        Handheld.Vibrate();
    }
}
