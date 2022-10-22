using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleTap : MonoBehaviour
{
      int tapCount;
      float doubleTapTimer;
      public gameManager gManage;
    // Start is called before the first frame update
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
             tapCount++;
         }
         if (tapCount > 0)
         {
             doubleTapTimer += Time.deltaTime;
             
         }
         if (tapCount >= 2)
         {
             //What you want to do
            
             doubleTapTimer = 0.0f;
             tapCount = 0;
             if(gManage.gameState == 2)
             {
                 gManage.gameState = 1;
                 return;
             }
               if(gManage.gameState == 1)
             {
                 gManage.gameState = 2;
                 return;
             }
               if(gManage.gameState == 3)
             {
                 gManage.gameState = 1;
                 return;
             }
             
            
             
           
         }
         if (doubleTapTimer > 0.5f)
         {
             doubleTapTimer = 0f;
             tapCount = 0;
         }
    }
}
