using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreditDrain : MonoBehaviour
{
    CreditsVariable creditCode;
    // Start is called before the first frame update
    void Start()
    {
        creditCode = GameObject.FindGameObjectWithTag("Player").GetComponent<CreditsVariable>();
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TriggerEntered");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Damage player");
            creditCode.DrainCredits();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
