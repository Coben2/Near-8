using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1stPersonIntroMaze : MonoBehaviour
{
    public int gameState;
    public Camera MainCamera;
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

    public GameObject ballController;
    private Controller controller;
    private CharacterController charcon4Joy;

    public GameObject joystickInstruct;
    public float joyinstructTimer;

    //public SwipeDetector swipeDetect;
    //public SwipeLogger swipeLog;

    int tapCount;
    float doubleTapTimer;

    Transform ControlTrans;

    void Start()
    {
        ControlTrans = ballController.transform;

        controller = ballController.GetComponent<Controller>();
        charcon4Joy = ballController.GetComponent<CharacterController>();


        if (isTiltScene == true)
        {
            gameState = 1;
            Cam2active = false;
            CineCam2.SetActive(false); //ground camera
                                       //instructTimer = 3f;
                                       // swipeLog.enabled = false;
                                       //swipeDetect.enabled = false;
            MainCamera.orthographic = true;
        }
        else
        {
            gameState = 2;
            buttonTimer = 4f;
            buttonSpot.SetActive(true);
            Cam2active = true;  //makes the accelerometer movement turn on in ballGyro script
            CineCam2.SetActive(true); //ground camera
                                      // swipeLog.enabled = false;
                                      //swipeDetect.enabled = false;
            MainCamera.orthographic = false;

            gyroScriptLevel.GetComponent<gyroScope>().enabled = false;
            gyroScriptBall.GetComponent<gyroScope>().enabled = true;
            bGyro.enabled = true;
            CineCam2.SetActive(false);
        }
    }

    void Update()
    {

        Vector3 eulers = ControlTrans.eulerAngles;

        joyinstructTimer -= Time.deltaTime;
        buttonTimer -= Time.deltaTime;

        if (joyinstructTimer <= 0)
        {
            joystickInstruct.SetActive(false);
        }

        if (buttonTimer <= 0)
        {
            buttonSpot.SetActive(false);
        }
        GameStates();
        if (isTiltScene == true)
        {
            dTap();
        }

        if (gameState == 1)
        {
            ControlTrans.eulerAngles = new Vector3(eulers.x, eulers.y, eulers.z);
            //ballController.transform = ControlTrans;
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

                MainCamera.orthographic = true;
                //swipeDetect.enabled = false;
                //swipeLog.enabled = false;
                break;

            case 2:
                gyroScriptBall.GetComponent<Rigidbody>().useGravity = true;

                //DISABLE/ENABLE for NO Joystick
                controller.enabled = false;
                charcon4Joy.enabled = false;

                lookaround.SetActive(false);
                joystickVisual.SetActive(false);
                //gyroScriptBall.SetActive(true);
                //Playerjoystick.SetActive(false);


                MainCamera.orthographic = false;

                //buttonTimer = 4f;
                //buttonSpot.SetActive(true);

                //Switch to ground
                gyroScriptLevel.GetComponent<gyroScope>().enabled = false;
                gyroScriptBall.GetComponent<gyroScope>().enabled = true;
                bGyro.enabled = true;
                CineCam2.SetActive(true);
                JoystickCam.SetActive(false);
                CineCam1.SetActive(false);
                //gyroScriptLevel.transform.rotation = Quaternion.Euler(0, 0, 0);
                Cam2active = true;


                gyroScriptBall.GetComponent<SphereCollider>().enabled = true;
                //instructionsPop = true;
                //swipeDetect.enabled = false;
                //swipeLog.enabled = false;


                break;

            case 3:
                
                

                //Disable Free look Camera
                gyroScriptLevel.GetComponent<gyroScope>().enabled = false;
                gyroScriptBall.GetComponent<gyroScope>().enabled = false;
                bGyro.enabled = false;
                Cam2active = false;
                //gyroScriptLevel.transform.rotation = Quaternion.Euler(0, 0, 0);
                //swipeDetect.enabled = true;
                //swipeLog.enabled = true;

                //DISABLE/ENABLE for Joystick
                controller.enabled = true;
                charcon4Joy.enabled = true;

                lookaround.SetActive(true);
                joystickVisual.SetActive(true);
                //Playerjoystick.SetActive(true);
                //gyroScriptBall.SetActive(false);

                gyroScriptBall.GetComponent<SphereCollider>().enabled = false;
                gyroScriptBall.GetComponent<Rigidbody>().useGravity = false;

                CineCam2.SetActive(false);
                JoystickCam.SetActive(true);

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
            joystickInstruct.SetActive(true);
            joyinstructTimer = 5f;

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
