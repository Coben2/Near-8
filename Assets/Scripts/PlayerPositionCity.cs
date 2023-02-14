using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionCity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Indestructable.instance.prevSceneName.Contains("Theater"))
        {
            transform.localPosition = new Vector3(86.6f, 0.55f, -27);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Indestructable.instance.prevSceneName.Contains("NightClubScene Separate"))
        {
            transform.localPosition = new Vector3(88.6f, 0.55f, 36.7f);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
