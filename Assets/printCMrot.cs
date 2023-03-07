using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class printCMrot : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;

    // Start is called before the first frame update
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Print());
    }

    IEnumerator Print()
    {
        yield return new WaitForSeconds(3);
        Debug.Log(vcam.State.CorrectedOrientation.x);
        Debug.Log(Camera.main.transform.eulerAngles.x);
        //Debug.Log(vcam.State.CorrectedOrientation.z);
    }
}
