using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageEnemys : MonoBehaviour
{
    [SerializeField] private Enemys _enemys;
    [SerializeField] private HealthUI _healUI;

   private void Start()
    {
        _enemys = GetComponent<Enemys>();
    }

    public void TakeDamage(int damageValue)
    {

        _enemys.SetEnemysHealth(_enemys.GetEnemysHealth() - damageValue);

        if (_enemys.GetEnemysHealth() <= 0)
        {
            Destroy(gameObject);
        }
        _healUI.DisplayHealth(_enemys.GetEnemysHealth());
    }
}
