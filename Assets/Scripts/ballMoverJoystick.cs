using System;
using UnityEngine;

public class BallMoverJoystick : MonoBehaviour, IPlayer
{
    public Vector2 movementVector { get; }

    private JoystickMove joystickMove;
    // Start is called before the first frame update
    void Start()
    {
        joystickMove.OnMove += JoystickMove_OnMove;
    }

    private void JoystickMove_OnMove(Vector2 obj)
    {
        throw new NotImplementedException();
    }

    public void VectorMove(Vector2 obj)
    {
        throw new NotImplementedException();
    }
}
