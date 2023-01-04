using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SceneManagerWhite : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam;
    private Animator camAnim;

    private void Start()
    {
        camAnim = cam.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camAnim.Play("Outro");
        }
    }
}
