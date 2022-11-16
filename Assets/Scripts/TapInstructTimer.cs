using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapInstructTimer : MonoBehaviour
{
    public float Tapinstructtimer;
    public GameObject tapInstruct;   //the game object here should be a panel with text in it and should be off by default

    // Start is called before the first frame update
    void Start()
    {
        Tapinstructtimer = 8f;         //sets the timer for this to 8. (change that number to alter timing)
    }

    // Update is called once per frame
    void Update()
    {
        Tapinstructtimer -= Time.deltaTime;         //subtracts one from the timer each frame

        if (Tapinstructtimer <= 4)              //when the timer gets down to 3,
        {
            tapInstruct.SetActive(true);        //turn on the game object in tapInstruct.
        }
        
        if (Tapinstructtimer <= 0)              //when the timer gets down to 0 (and past it),
        {
            tapInstruct.SetActive(false);       //turn off the game object in tapInstruct.
        }
    }
}
