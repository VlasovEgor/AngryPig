using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPlayer : MonoBehaviour
{
    private float _boostSpeed;
    private float _speedTMP;

    [SerializeField] private PlayerMove _playerMove;


    [SerializeField] private ChargeIcon _chargeIcon;
    [SerializeField] private float _maxCharge;
    private float _currentCharge;
    private bool _isCharged;

    private void Start()
    {
        _speedTMP = _playerMove.GetSpeed();
        _boostSpeed = _playerMove.GetBoost();
    }

    private void Update()
    {
        CheckingAccelerationReadiness();
    }

    private void CheckingAccelerationReadiness()
    {
        if (!_isCharged)
        {
            _currentCharge += Time.deltaTime;
            _chargeIcon.SetValue(_currentCharge, _maxCharge);
        }
        if (_currentCharge >= _maxCharge)
        {

            _isCharged = true;
            _chargeIcon.Stop();
        }
    }

    public void Boost()
    {
        if (_isCharged)
        {
            _playerMove.SetSpeed(_boostSpeed*_playerMove.GetSpeed());
            _chargeIcon.Begin();
            _currentCharge = 0;
            _isCharged = false;
            Invoke("StopBoost", _playerMove.GetTimeBoost());
        }
    }

    private void StopBoost()
    {
        _playerMove.SetSpeed(_speedTMP);
    }
}