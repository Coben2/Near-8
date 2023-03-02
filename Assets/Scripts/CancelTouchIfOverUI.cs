using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CancelTouchIfOverUI : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (IsPointerOverUI(touch.fingerId))
            {
                return;
            }
        }
        bool IsPointerOverUI(int fingerId)
        {
            EventSystem eventSystem = EventSystem.current;
            return (eventSystem.IsPointerOverGameObject(fingerId)
             && eventSystem.currentSelectedGameObject != null);
        }
    }
}
