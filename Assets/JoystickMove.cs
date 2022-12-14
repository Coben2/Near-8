using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System; 

public class JoystickMove : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{ 
    [SerializeField] private RectTransform joystickTransform;

    [SerializeField] private float dragThreshold = 0.6f;

    [SerializeField] private int dragMovementDistance = 30;

    [SerializeField] private int dragOffsetDistance;

    public event Action<Vector2> OnMove;



    private Vector2 CalculateMovementInput(Vector2 offset)
    {
        float x = Mathf.Abs(offset.x) > dragThreshold ? offset.x : 0;
        float y = Mathf.Abs(offset.y) > dragThreshold ? offset.y : 0;
        return new Vector2(x, y);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 offset;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickTransform, eventData.position, null, out offset);
        offset = Vector2.ClampMagnitude(offset, dragOffsetDistance) / dragOffsetDistance;
        Debug.Log(offset);
        joystickTransform.anchoredPosition = offset * dragMovementDistance;
        Vector2 input = CalculateMovementInput(offset);
        OnMove?.Invoke(input);
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        joystickTransform.anchoredPosition = Vector2.zero;
        OnMove?.Invoke(Vector2.zero);
    }

    private void Awake()
    {
        joystickTransform = (RectTransform)transform;
    }
}
