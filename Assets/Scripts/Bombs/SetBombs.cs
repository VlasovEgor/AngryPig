using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBombs : MonoBehaviour
{


    private Transform _playerTransform;
    [SerializeField] private GameObject _bombPrefab;
    [SerializeField] private ChargeIcon _chargeIcon;
    [SerializeField] private float _maxCharge = 5f;
    private float _currentCharge;
    private bool _isCharged;
    private Vector2 _bombTransfrom;
    private void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }
    public void Set()
    {
        
        if (_isCharged)
        {
            _bombTransfrom = _playerTransform.position;
            _currentCharge = 0;
            _isCharged = false;
            _chargeIcon.Begin();
            Invoke("Delay", 0.2f);
        }
    }

    private void Delay()
    {
        Instantiate(_bombPrefab, _bombTransfrom, Quaternion.identity);
    }
    private void Update()
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
}
