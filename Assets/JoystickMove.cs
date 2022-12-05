using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JoystickMove : MonoBehaviour
{
    [Header("New Input Properties")]
    public NEW_BALL_MOVEMENT_JOYSTICK inputActions;
    public InputAction joystick;

    [Header("Ball Movement")]
    public GameObject player; 
    public float speed;
    private Vector2 currentMovement;
    private void Awake()
    {
        inputActions = new NEW_BALL_MOVEMENT_JOYSTICK();
        joystick = inputActions.Movement.Move;

        joystick.performed += ctx => currentMovement = ctx.ReadValue<Vector2>();
        joystick.canceled += ctx => currentMovement = Vector2.zero;
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        Vector3 move = new Vector3(currentMovement.x, 0, currentMovement.y);
        if (joystick.IsPressed())
        {
            player.transform.Translate(move * speed * Time.deltaTime);
        }
    }
    private void OnEnable()
    {
        inputActions.Movement.Enable();
    }

    private void OnDisable()
    {
        inputActions.Movement.Disable();
    }
}
