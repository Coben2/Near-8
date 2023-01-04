using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightOn : MonoBehaviour
{

    public GameObject theLight;
    //public GameObject myplayer;

    public void OnTriggerEnter()
    {
        theLight.SetActive(true);
    }
    public void OnTriggerExit()
    {
        theLight.SetActive(false);
    }
}
