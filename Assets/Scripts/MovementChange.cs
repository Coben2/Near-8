using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChange : MonoBehaviour
{
    public int gameState;
    public bool isTiltScene;
    public GameObject buttonSpot;
    public float buttonTimer;
    public GameObject joystickVisual;
    public GameObject lookaround;

    public GameObject CineCam1;     //for overhead cam in tilt maze. if different scenes, use a script to set GameState 2 automaticly
    public GameObject CineCam2;
    public bool Cam2active;
    public GameObject JoystickCam;

    public ballGyroCINE bGyro;
    public GameObject gyroScriptLevel; //the structure of the level (must have gyroScope script on it)
    public GameObject gyroScriptBall; //ball (or the player, whatever you wanna call it)(also needs gyroScope)
    public GameObject Playerjoystick;

    public SwipeDetector swipeDetect;
    public SwipeLogger swipeLog;

    int tapCount;
    float doubleTapTimer;

    void Start()
    {
        if (isTiltScene == true)
        {
            gameState = 1;
            Cam2active = false;
            CineCam2.SetActive(false); //ground camera
            //instructTimer = 3f;
            swipeLog.enabled = false;
            swipeDetect.enabled = false;
        }
        else
        {
            gameState = 2;
            buttonTimer = 4f;
            buttonSpot.SetActive(true);
            Cam2active = true;  //makes the accelerometer movement turn on in ballGyro script
            CineCam2.SetActive(true); //ground camera
            swipeLog.enabled = false;
            swipeDetect.enabled = false;

            gyroScriptLevel.GetComponent<gyroScope>().enabled = false;
            gyroScriptBall.GetComponent<gyroScope>().enabled = true;
            bGyro.enabled = true;
            CineCam2.SetActive(false);
        }
    }

    void Update()
    {
        GameStates();
        buttonTimer -= Time.deltaTime;
        if (buttonTimer <= 0)
        {
            buttonSpot.SetActive(false);
        }

        if (isTiltScene == true)
        {
            dTap();
        }
    }

 

    void dTap()         //SWITCHES GAME STATE IF PLAYER TAPS TWICE
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            tapCount++;
        }
        if (tapCount > 0)
        {
            doubleTapTimer += Time.deltaTime;

        }
        if (tapCount >= 2)                 
        {
            doubleTapTimer = 0.0f;   
            tapCount = 0;     
            if (gameState == 2)  
            {
                gameState = 1; 
                return;
            }
            if (gameState == 1)  
            {
                gameState = 2; 
                return;
            }
            if (gameState == 3)  
            {
                gameState = 1;  
                return;
            }
        }

        if (doubleTapTimer > 0.5f) 
        {
            doubleTapTimer = 0f;  
            tapCount = 0;    
        }
    }

    void GameStates()           //DEFINES THE DIFFERENT GAME STATES' PERAMETERS
    {

        switch (gameState)
        {
            case 1:
                //Default view
                gyroScriptLevel.GetComponent<gyroScope>().enabled = true;
                gyroScriptBall.GetComponent<gyroScope>().enabled = false;
                CineCam1.SetActive(true);
                CineCam2.SetActive(false);
                bGyro.enabled = true;
                Cam2active = false;
                swipeDetect.enabled = false;
                swipeLog.enabled = false;
                break;

            case 2:
                //DISABLE/ENABLE for NO Joystick
                gyroScriptBall.SetActive(true);
                Playerjoystick.SetActive(false);
                gyroScriptBall.GetComponent<ModelFollowBall>().enabled = false;
                Playerjoystick.GetComponent<ModelFollowBall>().enabled = true;

                lookaround.SetActive(false);
                joystickVisual.SetActive(false);

                //Switch to ground
                gyroScriptLevel.GetComponent<gyroScope>().enabled = false;
                gyroScriptBall.GetComponent<gyroScope>().enabled = true;
                bGyro.enabled = true;
                CineCam2.SetActive(true);
                JoystickCam.SetActive(false);
                CineCam1.SetActive(false);
               // gyroScriptLevel.transform.rotation = Quaternion.Euler(90, 0, 0);
                Cam2active = true;
                //instructionsPop = true;
                swipeDetect.enabled = false;
                swipeLog.enabled = false;

                break;

            case 3:
                //Disable Free look Camera
                gyroScriptLevel.GetComponent<gyroScope>().enabled = false;
                gyroScriptBall.GetComponent<gyroScope>().enabled = false;
                bGyro.enabled = false;
                Cam2active = true;
                //gyroScriptLevel.transform.rotation = Quaternion.Euler(90, 0, 0);
                //swipeDetect.enabled = true;
                //swipeLog.enabled = true;

                //DISABLE/ENABLE for Joystick
                Playerjoystick.SetActive(true);
                gyroScriptBall.SetActive(false);
                Playerjoystick.GetComponent<ModelFollowBall>().enabled = false;
                gyroScriptBall.GetComponent<ModelFollowBall>().enabled = true;

                CineCam2.SetActive(false);
                JoystickCam.SetActive(true);

                lookaround.SetActive(true);
                joystickVisual.SetActive(true);

                break;
        }
    }

    public void leftButton()            //WHEN BUTTON IS PRESSED, SWITCHES BETWEEN GAMESTATES 2(gyro motion) AND 3(swipe motion)
    {
        if (gameState == 2)
        {
            gameState = 3;
            //gyroScriptBall.transform.eulerAngles = new Vector3(0f, 90f, 0f);

            buttonSpot.SetActive(true);
            buttonTimer = 3;

            //gyroScriptBall.GetComponent<gyroScope>().enabled = false;
            //bGyro.enabled = false;
            //swipeDetect.enabled = true;
            //swipeLog.enabled = true;
            //// tap2.enabled = true;

            return;
        }
        if (gameState == 3)
        {
            gameState = 2;

            buttonSpot.SetActive(true);
            buttonTimer = 3;

            //gyroScriptBall.GetComponent<gyroScope>().enabled = true;
            //bGyro.enabled = true;
            //swipeDetect.enabled = false;
            //swipeLog.enabled = false;
            //// tap2.enabled = false;

            return;
        }
    }
}
