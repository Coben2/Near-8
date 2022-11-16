using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructTimer : MonoBehaviour
{
    public GameObject Scriptholder;
    public float Countdown;
    public int CountInt;
    public GameObject panel;
    public GameObject baseText;
    public GameObject five;
    public GameObject four;
    public GameObject three;
    public GameObject two;
    public GameObject one;
    public string url;

    // Start is called before the first frame update
    void Start()
    {
        Countdown = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown -= Time.deltaTime;
        CountInt = Mathf.RoundToInt(Countdown);

        if (CountInt >= 0 && CountInt <= 6)
        {
            baseText.SetActive(true);
            panel.SetActive(true);
        }

        if (CountInt == 5)
        {
            five.SetActive(true);
        }
        if (CountInt == 4)
        {
            four.SetActive(true);
            five.SetActive(false);
        }
        if (CountInt == 3)
        {
            three.SetActive(true);
            four.SetActive(false);
        }
        if (CountInt == 2)
        {
            two.SetActive(true);
            three.SetActive(false);
        }
        if (CountInt == 1)
        {
            one.SetActive(true);
            two.SetActive(false);
        }
       // if (CountInt == 0)
        //{
           // Application.OpenURL(url);
           // Scriptholder.SetActive(false);
        //}
    }
}
