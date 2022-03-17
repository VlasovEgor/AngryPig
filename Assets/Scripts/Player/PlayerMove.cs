using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _boost;
    [SerializeField] private float _timeBoost=1.5f;
    private float _speedTMP;
    [SerializeField] private TargetMove _targetMove;
    private Transform _playerTransfrom;
    

    public float GetSpeed()
    {
        return _moveSpeed;
    }
    public void SetSpeed(float speed)
    {
        _moveSpeed = speed;
    }
    public float GetBoost()
    {
        return _boost;
    }
    public float GetTimeBoost()
    {
        return _timeBoost;
    }

    private void Start()
    {
        _playerTransfrom = GetComponent<Transform>();
        _speedTMP = _moveSpeed;
    }

    private void Update()
    {
        Move(_targetMove.InputVector);
        if(_moveSpeed==0)
        {
            Invoke("ReturnSpeed", 1f);
        }
    }

    private void Move(Vector2 moveDirection)
    {
        moveDirection *= _moveSpeed;
        var position = _playerTransfrom.position;
        position += new Vector3(moveDirection.x, moveDirection.y,0) * Time.deltaTime;
        _playerTransfrom.position = position;
    }

    private void ReturnSpeed()
    {
        _moveSpeed = _speedTMP;
    }

}