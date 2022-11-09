using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap2Move : MonoBehaviour
{
    public int tapCount;
    public float doubleTapTimer;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tap();
    }

    void tap()
    {
        
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)   //if the touchCount is equal to 1 (or if necessary is equal to 
         {
             tapCount++;      //increments tapCount (from tap2Move) by 1
         }
         if (tapCount > 0)             //if tapCount is greater than 0,
         {
             doubleTapTimer += Time.deltaTime;      //adds [value of the interval (in seconds) from the last frame to the current one] to the value of doubleTapTimer (from the tap2Move script)
             
         }
         if (tapCount >= 2)             //if tapCount is greaterthan or equal to 2,
         {
             transform.Translate(Vector3.forward * speed );     //moves ___ along Vector3 (0,0,1) at speed defined in tap2Move script
             doubleTapTimer = 0.0f;                             //sets doubleTapTimer (from tap2Move) to 0
            tapCount = 0;                                       //sets tapCount to 0
         }
         if (doubleTapTimer > 0.5f)     //if doubleTapTimer is greater than 0.5f,
         {
             doubleTapTimer = 0f;           //sets doubleTapTimer to 0 
             tapCount = 0;                  //sets tapCount to 0
         }
    }

    public void moveUp()
    {
        transform.Translate(Vector3.forward * .08f );
    }

    public void moveDown()
    {
        transform.Translate(Vector3.back * .08f);
    }
}

