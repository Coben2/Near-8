  using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class swipeMove : MonoBehaviour
{
    
    public Vector2 startPos;
    public Vector2 direction;
    public bool directionChosen;
 
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
             // Track a single touch as a direction control.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    startPos = touch.position;
                    directionChosen = false;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    directionChosen = true;
                    break;
            }
        }
        if (directionChosen)
        {
            //Rashid
            float distanceInX = Mathf.Abs(direction.x);
            float distanceInY = Mathf.Abs(direction.y);
            Debug.Log(distanceInX);
            Debug.Log(distanceInY);


            // Something that uses the chosen direction...
          //  Debug.Log(direction);
            directionChosen = false;
           // transform.Rotate();
            // if(direction.x <= 100)
            // {
            //     Debug.Log("left");
            // }
            //  if(direction.x >= 100)
            // {
            //      Debug.Log("right");
            // }
            //  if(direction.y <= 100)
            // {
            //      Debug.Log("down");
            // }
            //  if(direction.y >= 100)
            // {
            //      Debug.Log("up");
            // }
        }

    }
}
