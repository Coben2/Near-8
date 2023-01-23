using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatHashShowbutton : MonoBehaviour
{
    public GameObject hash;
    public GameObject hashButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (hash.transform.position - transform.position).normalized;
        float dot = Vector3.Dot(dir, transform.forward);

        if (dot >= 0.9)
        {
            hashButton.SetActive(true);
        }
        else
        {
            hashButton.SetActive(false);
        }
    }
}
