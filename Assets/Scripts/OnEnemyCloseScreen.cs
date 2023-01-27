using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnemyCloseScreen : MonoBehaviour
{
    public GameObject DamageScreen;

    public float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime;
    }


    private void OnTriggerEnter(Collider Col)
    {
        if (timer > 15)
        {
            if (Col.gameObject.CompareTag("Enemy"))
            {
                //Debug.Log("Enemy Entered Trigger");
                StartCoroutine(TurnOnScreen());
                StopCoroutine(TurnOffScreen());
            }
        }
        
    }
    private void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(TurnOffScreen());
            StopCoroutine(TurnOnScreen());
        }
    }
    private IEnumerator TurnOnScreen()
    {
        yield return new WaitForSeconds(0.3f);
        DamageScreen.SetActive(true);
    }
    private IEnumerator TurnOffScreen()
    {
        yield return new WaitForSeconds(0.0f);
        DamageScreen.SetActive(false);
    }
}
