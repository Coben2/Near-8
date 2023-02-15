using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LookRotationJoystickHallway : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachine;
    // Start is called before the first frame update
    void Start()
    {
        cinemachine = GetComponent<CinemachineVirtualCamera>();
        if (Indestructable.instance.prevSceneName.Contains("CityScape"))
        {
            CinemachinePOV pov = cinemachine.GetCinemachineComponent<CinemachinePOV>();
            pov.m_HorizontalAxis.Value = -90;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
