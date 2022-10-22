using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class recordMaanger : MonoBehaviour
{
    public Camera recordCam;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    //    recordCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(recordCam.orthographicSize >= 6.21f){
        recordCam.orthographicSize = recordCam.orthographicSize - speed * Time.deltaTime;
        }
        if(recordCam.orthographicSize <= 6.21)
        {
             SceneManager.LoadScene("Aspect-Ratio");
        }
    }
}
