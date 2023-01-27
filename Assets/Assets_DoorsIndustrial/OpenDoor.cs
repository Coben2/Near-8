using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator animator;
    public float OpenCounter;
    public float CloseCounter;

    private void Start()
    {
        animator = GetComponent<Animator>();
        OpenCounter = 0;
        CloseCounter = 1;
    }

    private void Update()
    {
        OpenCounter = OpenCounter + Time.deltaTime;
        CloseCounter = CloseCounter - Time.deltaTime;
    }

    private void OnTriggerEnter(Collider Col)
    {
        OpenCounter = 0;
        if (Col.gameObject.CompareTag("Player"))
        {
            OpenCounter = 0;
            InvokeRepeating("OpendaDoor", 0.0f, 0.01f);
        }
    }

    void OpendaDoor()
    {
        animator.SetFloat("OpenClose",OpenCounter);
    }

    private void OnTriggerExit(Collider Col)
    {
        CancelInvoke("OpendaDoor");
        CloseCounter = 1;
        if (Col.gameObject.CompareTag("Player"))
        {
            CloseCounter = 1;
            InvokeRepeating("CloseDoor", 0.0f, 0.01f);
        }
    }

    void CloseDoor()
    {
        animator.SetFloat("OpenClose", CloseCounter);
    }
   // Debug.Log("Trigger entered");
}
