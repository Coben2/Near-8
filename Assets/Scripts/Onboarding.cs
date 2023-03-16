using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onboarding : MonoBehaviour
{
    public float Countdown;
    public int CountInt;

    public GameObject panel;
    public GameObject text1;
    public GameObject arrow1;
    public GameObject text2;
    public GameObject arrow2;
    public GameObject text3;
    public GameObject arrow3;
    public GameObject gotIt;

    void Start()
    {
        Countdown = 13f;
    }

    void Update()
    {
        Countdown -= Time.unscaledDeltaTime;
        CountInt = Mathf.RoundToInt(Countdown);

        if (Countdown <= 6)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            text1.SetActive(true);
            arrow1.SetActive(true);
        }
        if (Countdown <= 4)
        {
            text2.SetActive(true);
            arrow2.SetActive(true);
        }
        if (Countdown <= 2)
        {
            text3.SetActive(true);
            arrow3.SetActive(true);
        }
        if (Countdown <= 1)
        {
            gotIt.SetActive(true);
        }
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

}
