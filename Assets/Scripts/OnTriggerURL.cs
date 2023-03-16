using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerURL : MonoBehaviour
{

    public string URL;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Application.OpenURL(URL);
    }
}
