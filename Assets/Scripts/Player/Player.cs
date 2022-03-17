using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private HealthUI _healthUI;
    private void Start()
    {
        _healthUI.Setup(_health);
    }
    public int GetPlayerHealth()
    {
        return _health;
    }
    public void SetPlayerHealth(int newHealth)
    {
        _health = newHealth;
    }

}
