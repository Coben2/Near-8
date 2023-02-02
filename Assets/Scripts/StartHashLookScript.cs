using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHashLookScript : MonoBehaviour
{
    LookatHashShowbutton hashScript;

    // Start is called before the first frame update
    void Start()
    {
        hashScript = Camera.main.GetComponent<LookatHashShowbutton>();
    }

    private void OnTriggerEnter(Collider other)
    {
        hashScript.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        hashScript.enabled = false;
    }
}
