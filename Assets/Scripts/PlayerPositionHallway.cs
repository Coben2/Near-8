using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionHallway : MonoBehaviour
{

    //private Transform playerposition;
    // Start is called before the first frame update
    void Start()
    {
        //playerposition = GameObject.FindGameObjectWithTag("Player").transform;
        if (Indestructable.instance.prevSceneName.Contains("CityScape"))
        {
            transform.localPosition = new Vector3(56, 0.55f, -4);
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        //else
        //{
            
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
