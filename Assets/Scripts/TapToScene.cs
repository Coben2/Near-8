using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapToScene : MonoBehaviour
{
    int tapCount;                     //defines an integer "tapCount"
    float doubleTapTimer;             //defines a floating point value "doubleTapTimer"

    void Start()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            tapCount++;                //when screen is touched, adds 1 to tapCount integer
        }
        if (tapCount > 0)
        {
            doubleTapTimer += Time.deltaTime;      //if the tapCount is greater than 0, doubleTapTimer starts counting frames

        }
        if (tapCount >= 2)                    //if the tapCount is greaterthan or equal to 2,
        {
            doubleTapTimer = 0.0f;         //set doubleTapTimer to 0
            tapCount = 0;                  //set tapCount to 0
            SceneManager.LoadSceneAsync("Extended Maze Outdoor");

        }
        if (doubleTapTimer > 0.5f)         //if doubleTapTimer floating-point value is greater than 0.5(floating),
        {
            doubleTapTimer = 0f;               //set doubleTapTimer to 0
            tapCount = 0;                      //set tapCount to 0
        }
    }
}