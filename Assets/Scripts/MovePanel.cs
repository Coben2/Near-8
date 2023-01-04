using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanel : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed = 10;
    RectTransform anchpos;
    void Update()
    {
        anchpos = GetComponent<RectTransform>();
        //anchpos = Vector3.Lerp(anchpos, targetPosition, speed * Time.deltaTime);
    }
}
