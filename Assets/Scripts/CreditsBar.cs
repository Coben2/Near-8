using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsBar : MonoBehaviour
{
    public Image healthBarImage;
    public CreditsVariable credits;
    public Text creditnum;

    public void Update()
    {
        UpdateCreditBar();
    }
    public void UpdateCreditBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(credits.credits / credits.maxCredits, 0, 1f);
        creditnum.text = credits.credits.ToString();
    }
}
