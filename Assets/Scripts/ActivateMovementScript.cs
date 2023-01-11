using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMovementScript : MonoBehaviour
{

    public GameObject Manager;
    public GameObject Canvas;
    Movement1stPersonIntroMaze Script;

    private void Start()
    {
        Canvas.SetActive(false);
        Script = Manager.GetComponent<Movement1stPersonIntroMaze>();
        Script.enabled = false;
    }
    public void ActivateManager()
    {
        Script.enabled = true;
        Canvas.SetActive(true);
    }
}
