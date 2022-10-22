using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
        bool oneStop = true;
          float timer = 1f;
          public GameObject ball;
          public int speed;
          public GameObject ballCam;

          public tap2Move tap2;
          public gameManager gManage;
          public detectPeek peekScript;


    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
    
      
        if(oneStop)
        {
            // Debug.Log("Swipe in Direction: " + data.Direction);
            rotateDirection(data);
            oneStop = false;
            timer = 1;
        }
        
        
    }

    void Update()
    {

        //   ballCam.transform.rotation = transform.rotation;
          ball.transform.rotation = ballCam.transform.rotation;
          
        
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            oneStop = true;      
        } 

        // Debug.Log(ballCam.transform.eulerAngles);
    }

    void rotateDirection(SwipeData data)
    {
        string directionName = data.Direction.ToString();
        if( directionName == "Right")
        {
         
            ball.transform.Rotate(0f,-5,0f * speed  );
        }
         if( directionName == "Left")
        {
           
            ball.transform.Rotate(0f,5f,0f * speed  );
        }
         if( directionName == "Up")
        {
         
            // ball.transform.Rotate(-1f,0f,0f * speed * Time.deltaTime);

            // if(ballCam.transform.eulerAngles.x < 310f)
            // ballCam.transform.eulerAngles =  new Vector3 (310f,ballCam.transform.eulerAngles.y,ballCam.transform.eulerAngles.z);

            //swipe up to move forward

            tap2.moveUp();
            if(gManage.gameState == 4)
            {
                 gManage.gameState = 2;
                
            }

            
        }
         if( directionName == "Down")
        {
          
            tap2.moveDown();
            if(gManage.gameState == 4)
            {
                gManage.gameState = 2;
               
            }
        }
    }
}