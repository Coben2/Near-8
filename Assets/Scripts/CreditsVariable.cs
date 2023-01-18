using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsVariable : MonoBehaviour
{
    public float credits, maxCredits;
    public CreditsBar creditsbar;

    public void DrainCredits()
    {
        //credits = 100;
        //maxCredits = 1000;

        credits -= Mathf.Min(1, credits);
        creditsbar.UpdateCreditBar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            DrainCredits();
        }
    }
}
