using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickForMovement : JoystickHandler
{
    [SerializeField] private PlayerMove _playerMove;
    private void Update()
    {
        if (_inputVector.x != 0 || _inputVector.y != 0)
        {
           // _playerMove.Move(ReturnVectorDirection());
           // _playerMove.Rotate(ReturnVectorDirection());
        }
    }
    private Vector2 ReturnVectorDirection()
    {
        return new Vector2(_inputVector.x, _inputVector.y);
    }
    
}
