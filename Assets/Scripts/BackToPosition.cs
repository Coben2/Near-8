using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToPosition : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        transform.localPosition = new Vector3(0.019f, 0, 0.315f);
    }
}
