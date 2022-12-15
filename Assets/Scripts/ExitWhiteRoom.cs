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

    public void PortalPress()
    {
        // Debug.Log("trigger entered");
        camAnim.Play("Outro");

        //  Debug.Log("loaded scene");
    }
    public void HallwayPress()
    {
        // Debug.Log("trigger entered");
        camAnim.Play("ExitWhitetoHallway");

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
        SceneManager.LoadSceneAsync(gotoScene);
    }
}
