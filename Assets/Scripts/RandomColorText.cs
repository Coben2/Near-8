using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomColorText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMP_Text>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
