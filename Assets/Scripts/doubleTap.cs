using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleTap : MonoBehaviour
{
      int tapCount;                     //defines an integer "tapCount"
      float doubleTapTimer;             //defines a floating point value "doubleTapTimer"
      public gameManager gManage;       //defines gameManager (script) as gManage

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dTap();
    }

    void dTap()
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
             if(gManage.gameState == 2)     //if gameManager script's defined gameState integer is equal to 2,
             {
                 gManage.gameState = 1;         //set gameState to 1
                 return;
             }
               if(gManage.gameState == 1)   //if gameManager script's defined gameState int is equal to 1
             {
                 gManage.gameState = 2;         //set gameState to 2
                 return;
             }
               if(gManage.gameState == 3)   //if gameManager script's defined gameState int is equal to 3,
             {
                 gManage.gameState = 1;         //set gameState to 1
                 return;
             }
             
            
             
           
         }
         if (doubleTapTimer > 0.5f)         //if doubleTapTimer floating-point value is greater than 0.5(floating),
         {
             doubleTapTimer = 0f;               //set doubleTapTimer to 0
             tapCount = 0;                      //set tapCount to 0
         }
    }
}
