using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class ExitWhiteRoom : MonoBehaviour
{
    public string gotoScene;
    [SerializeField] private CinemachineVirtualCamera cam;
    private Animator camAnim;
    [SerializeField] private string url;

    public string sceneName;

    private void Start()
    {
        camAnim = cam.GetComponent<Animator>();
    }

    public IEnumerator PortalPress()
    {
        // Debug.Log("trigger entered");
        camAnim.Play("Outro");
        yield return null;

        //  Debug.Log("loaded scene");
    }
    public IEnumerator HallwayPress()
    {
        // Debug.Log("trigger entered");
        camAnim.Play("ExitWhitetoHallway");
        yield return null;

        //  Debug.Log("loaded scene");
    }
    public void BacktoHallway()
    {
        SceneManager.LoadSceneAsync("Hallway Updated");
    }
    public void HashURL()
    {
        Application.OpenURL(url);
    }
    public void NextWhiteRoom()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
        //Indestructable.instance.prevScene = Application.loadedLevel;
        Indestructable.instance.prevSceneName = sceneName;
        //Debug.Log("NextScene");
        SceneManager.LoadSceneAsync(gotoScene);
    }
}
