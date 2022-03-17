using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerHealth : MonoBehaviour
{
    private int _health;
    private bool _invulnerable=false;
   [SerializeField] private HealthUI _healthUI;

    private void Start()
    {
        _health = GetComponent<Player>().GetPlayerHealth();
    }

    public void TakeDamage(int damageValue)
    {
        if (_invulnerable == false)
        {
            _health -= damageValue;
            _healthUI.DisplayHealth(_health);
            GetComponent<Player>().SetPlayerHealth(_health);

            if (_health <= 0)
            {
                Die();
                _health = 0;
            }
        }
        _invulnerable = true;
        Invoke("StopInvulnerable", 1f);
        
    }
    private void StopInvulnerable()
    {
        _invulnerable = false;
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}