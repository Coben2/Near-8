using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    public Camera cameraThree;
    public GameObject gyroScriptObj1; //maze
    public GameObject gyroScriptObj2; //ball
    public GameObject gyroScriptObj3;
    public GameObject ball;
    public GameObject Maze;
    public bool groundCamIsOn;
    public ballGyro bGyro;
    public SwipeDetector swipeDetect;

    public SwipeLogger swipeLog;
    public Button button;

    public doubleTap dTap;
    
    public float instructTimer;
    public Text instructText;
    public GameObject panel;

    //Second instructions
    
    public float instructTimer2;
    public GameObject instructText2;
    public GameObject panel2;
    public Light ballLight;
    

    public tap2Move tap2;
    public bool disabled = false;

      public bool ran1 = false;
      public Button exit;
      public detectPeek dPeek;
      public Vector3 peekObj;
      public bool peekBool;
      public Quaternion currentRot;
      public GameObject buttonSpot;
      public  float countdown = 6f;
      public bool instructionsPop = false;
      public bool ran2 = false;
      public GameObject textOne;

      public bool triggered;
    // public swipeMove sMove;
    // Start is called before the first frame update

    public int gameState;
    void Start()
    {
        
        groundCamIsOn = false;
        cameraTwo.enabled = false; //ground camera
        instructTimer = 3f;
        instructTimer2 = 3f; //not being used
        exit.gameObject.SetActive(false);
        swipeLog.enabled = false;
        swipeDetect.enabled = false;
        peekBool = false;
        gameState = 1;
        triggered = false;
        
    }

    // Update is called once per frame
    void Update()
    {
         currentRot = ball.transform.rotation;

      
      if(groundCamIsOn == true)
      {
          button.gameObject.SetActive(true);
      }
      else
      {
          button.gameObject.SetActive(false);
      }

    instructTimer -= Time.deltaTime;

    //if(instructTimer <= 0)
   // {
      //  instructText.enabled = false;
       // panel.SetActive(false);
   // }

    //Second instructions
    SecondInstructions();
    Instructions();


    //REWORK
    reworKed(); //INSTEAD OF IN UPDATE USE METHOD WITH PARAMETER (SINGLE RESPONCIBILITY)
    }
    // public void switchToGround()
    // {
        
    //     gyroScriptObj1.GetComponent<gyroScope>().enabled = !gyroScriptObj1.GetComponent<gyroScope>().enabled ;
    //     gyroScriptObj2.GetComponent<gyroScope>().enabled = !gyroScriptObj2.GetComponent<gyroScope>().enabled ;
    //     cameraOne.enabled = !cameraOne.enabled;
    //     cameraTwo.enabled = !cameraTwo.enabled;
    //     Maze.transform.rotation = Quaternion.Euler(90,0,0);
    //     groundCamIsOn = !groundCamIsOn;
    //     ballLight.enabled = !ballLight.enabled;
    //     instructionsPop = true;
        

    // }
    //     public void disableMe()
    // {
    //     //Disable Free look Camera
    //      gyroScriptObj2.GetComponent<gyroScope>().enabled = !gyroScriptObj2.GetComponent<gyroScope>().enabled;
    //      bGyro.enabled = !bGyro.enabled;
    //      ball.transform.eulerAngles = new Vector3(0f,90f,0f);
    //     // ball.transform.rotation = currentRot;
    //     // ball.transform.rotation = new Quaternion(currentRot.eulerAngles.x,90f,currentRot.eulerAngles.z,0);
    //     // tap2.enabled = !tap2.enabled;
    //     swipeDetect.enabled = !swipeDetect.enabled;
    //     swipeLog.enabled = !swipeLog.enabled;
    //     disabled = true;
    // }

    // public void Peek()
    // {
    //     //Setup to peek and look through the doors
    //     gyroScriptObj1.GetComponent<gyroScope>().enabled = false;
    //     gyroScriptObj2.GetComponent<gyroScope>().enabled = true;
    //     Maze.transform.rotation = Quaternion.Euler(90,0,0);
    //     dTap.enabled = false;
    //     groundCamIsOn = true;
    //     cameraOne.enabled = false;
    //     cameraTwo.enabled = true;
    //     swipeDetect.enabled = true;
    //     swipeLog.enabled = true;
    //     exit.gameObject.SetActive(false);
    //     button.gameObject.SetActive(false);
     
        
    // }
    // public void Reset() {
    //     {
    //         //Releases ball from position
    //     gyroScriptObj2.GetComponent<gyroScope>().enabled = true;
    //     bGyro.enabled = true;
    //     Maze.transform.rotation = Quaternion.Euler(90,0,0);
    //     exit.gameObject.SetActive(false);
    //     dPeek.triggered = false;
    //     ball.transform.position = peekObj;
    //     groundCamIsOn = true;
    //     dTap.enabled = true;
    //     swipeDetect.enabled = false;
    //     swipeLog.enabled = false;
    //     }
    // }

    //Displays second instrcutions
    public void SecondInstructions() //ADD COROUTINE!
    {     
        if(disabled == true )
        {
             
            if(ran1 == false)
            {
                //Turn them on
                panel2.SetActive(true);
                instructText2.SetActive(true);       
                instructTimer2 -= Time.deltaTime;
                buttonSpot.SetActive(true);
                if(instructTimer2 <= 0)
                {
                     buttonSpot.SetActive(false);
                     panel2.SetActive(false);
                     instructText2.SetActive(false); //  instructText2.SetActive() =!instructText2.SetActive();
                     ran1 = true;
                    
                }   
            }   
        }
    }

    public void Instructions() //SAME COROUTINE AS SECOND INSTRUCTIONS
    {
        if(instructionsPop == true)
        {
            if(ran2 == false)
            {
                textOne.SetActive(true);
                buttonSpot.SetActive(true);
                countdown -= Time.deltaTime;
                if(countdown <= 0)
                {  
                     buttonSpot.SetActive(false);
                    textOne.SetActive(false);
                     ran2 = true;
                }
            }     
        }
    }


    void reworKed()
    {
        
        switch (gameState)
        {
        case 1:
            //Default view
            gyroScriptObj1.GetComponent<gyroScope>().enabled = true ;
            gyroScriptObj2.GetComponent<gyroScope>().enabled = false ;
            cameraOne.enabled = true;
            cameraTwo.enabled = false;
            bGyro.enabled = true;
            groundCamIsOn = false;
            ballLight.enabled = false;
            swipeDetect.enabled = false;
            swipeLog.enabled = false;
            
            break;
        case 2:
           //Switch to ground
            gyroScriptObj1.GetComponent<gyroScope>().enabled = false ;
            gyroScriptObj2.GetComponent<gyroScope>().enabled = true ;
            bGyro.enabled = true;
            cameraOne.enabled = false;
            cameraTwo.enabled = true;
            Maze.transform.rotation = Quaternion.Euler(90,0,0);
            groundCamIsOn = true;
            ballLight.enabled = true;
            instructionsPop = true;
            swipeDetect.enabled = false;
            swipeLog.enabled = false;
            triggered = false;
            dTap.enabled = true;
            break;
        case 3:
           //Disable Free look Camera
            gyroScriptObj1.GetComponent<gyroScope>().enabled = false ;
            gyroScriptObj2.GetComponent<gyroScope>().enabled = false ;
            bGyro.enabled = false;
            groundCamIsOn = true;
            Maze.transform.rotation = Quaternion.Euler(90,0,0);
            swipeDetect.enabled = true;
            swipeLog.enabled = true;
            disabled = true;
            dTap.enabled = true;
            break;
        case 4:
        //Peek
           gyroScriptObj1.GetComponent<gyroScope>().enabled = false;
           gyroScriptObj2.GetComponent<gyroScope>().enabled = true;
           Maze.transform.rotation = Quaternion.Euler(90,0,0);
           dTap.enabled = false;
           groundCamIsOn = true;
           cameraOne.enabled = false;
           cameraTwo.enabled = true;
           swipeDetect.enabled = true;
           swipeLog.enabled = true;
           exit.gameObject.SetActive(false);
           button.gameObject.SetActive(true);
            break;
        case 5:
            print ("Ulg, glib, Pblblblblb");
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
    }

    public void leftButton()
    {
        if(gameState == 2)
        {
        gameState = 3;
        ball.transform.eulerAngles = new Vector3(0f,90f,0f);
        return;
        }
        

        if(gameState == 3)
        {
        gameState = 2;
        return;
        
        }
    }
        
}
