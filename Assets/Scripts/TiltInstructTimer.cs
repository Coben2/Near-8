using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltInstructTimer : MonoBehaviour
{
    public float tiltinstructtimer;
    //private float Angle;
    public GameObject tiltInstruct;   //the game object here should be a panel with text in it and should be off by default
    public GameObject textDeactive1;
    public GameObject textDeactive2;

    // Start is called before the first frame update
    void Start()
    {
        tiltinstructtimer = 8f;         //sets the timer for this to 8. (change that number to alter timing)
       // Angle = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        tiltinstructtimer -= Time.deltaTime;         //subtracts one from the timer each frame
       // Angle -= 5f;
       // Quaternion target = Quaternion.Euler(0, 0, Angle);
       // transform.rotation = target;

        if (tiltinstructtimer <= 7)              //when the timer gets down to 7,
        {
            tiltInstruct.SetActive(true);        //turn on the game object in tapInstruct.
           // textDeactive1.SetActive(false);
           // textDeactive2.SetActive(false);
        }
        
        if (tiltinstructtimer <= 4)              //when the timer gets down to 4 (and past it),
        {
            tiltInstruct.SetActive(false);       //turn off the game object in tapInstruct.
        }
    }
}
