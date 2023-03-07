using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsAppear : MonoBehaviour
{

    public float Countdown;
    public int CountInt;

    public GameObject introCam;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;

    void Start()
    {
        Countdown = 18f;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown -= Time.deltaTime + 0.02f;
        CountInt = Mathf.RoundToInt(Countdown);

        if(CountInt == 15)
        {
            introCam.SetActive(false);
        }

        if (CountInt == 6)
        {
            button1.SetActive(true);
        }
        if (CountInt == 5)
        {
            button2.SetActive(true);
        }
        if (CountInt == 4)
        {
            button3.SetActive(true);
        }
        if (CountInt == 3)
        {
            button4.SetActive(true);
        }
        if (CountInt == 2)
        {
            button5.SetActive(true);
        }
        if (CountInt == 1)
        {
            button6.SetActive(true);
        }
    }
}
