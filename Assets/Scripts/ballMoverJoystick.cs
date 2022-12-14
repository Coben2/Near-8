using System;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using ETouch = UnityEngine.InputSystem.EnhancedTouch;

public class ballMoverJoystick : MonoBehaviour
{
    public JoystickMove joystickMove;

    private Finger movementFinger;

    private Vector2 moveAmount;


    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
        ETouch.Touch.onFingerDown += HandleFingerDown;
        ETouch.Touch.onFingerUp += Touch_onFingerUp;
        ETouch.Touch.onFingerMove += HandleFingerMove;
    }

    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();
        ETouch.Touch.onFingerMove -= HandleFingerMove;
        ETouch.Touch.onFingerDown -= HandleFingerDown;
        ETouch.Touch.onFingerUp -= Touch_onFingerUp;
    }

    private void HandleFingerMove(Finger MovedFinger)
    {
        if(MovedFinger == movementFinger)
        {
            ETouch.Touch currentTouch = MovedFinger.currentTouch;
            joystickMove.OnMove += Movement;
        }
    }

    private void Movement(Vector2 magnitude)
    {
        magnitude = movementFinger.currentTouch.delta ;
        float moveSpeed = 1.5f;
        transform.Translate(new Vector3(magnitude.x, 0, magnitude.y) * moveSpeed * Time.deltaTime, Space.World);
    }

    private void HandleFingerDown(Finger TouchedFinger)
    {
        if (movementFinger == null && TouchedFinger.screenPosition.x <= Screen.width / 2f)
        {
            movementFinger = TouchedFinger;
            moveAmount = Vector2.zero;
        }
    }

    private void Touch_onFingerUp(Finger obj)
    {
        throw new NotImplementedException();
    }

}
