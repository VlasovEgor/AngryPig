using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapButtons : MonoBehaviour
{
    [SerializeField] private TargetMove _targetMove;
    public void TupButtonUp()
    {
        _targetMove.InputVector.y = 1;
    }
    public void TupButtonDown()
    {
        _targetMove.InputVector.y = -1;
    }
    public void TupButtonLeft()
    {
        _targetMove.InputVector.x = -1;
    }
    public void TupButtonRight()
    {
        _targetMove.InputVector.x = 1;
    }

    public void OnButtonUp()
    {
        _targetMove.InputVector = Vector2.zero;
    }
}
