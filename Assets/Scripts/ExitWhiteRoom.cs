using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class ExitWhiteRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public string gotoScene;
    [SerializeField] private CinemachineVirtualCamera cam;
    private Animator camAnim;
    [SerializeField] private string url;

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
        //Debug.Log("NextScene");
        SceneManager.LoadSceneAsync(gotoScene);
    }
}
