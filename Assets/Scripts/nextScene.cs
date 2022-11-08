using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextScene : MonoBehaviour
{
    public float time;                  //defines a floating-point value "time"
    public RawImage rIMage;             //allows definition of a RawImage "rIMage"
    // Start is called before the first frame update
    void Start()
    {
        time = 4f;                      //sets time float to 4f at beginning of script
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;         //subtracts [the interval (in seconds) from the last frame to the current one] from time float once a frame

        if(time <= 0)                                 //if time float is less than or equal to 0,
        {
            SceneManager.LoadScene("Recording");            //load the scene "Recording" (which does not exist in current files)
        }
    }
}
