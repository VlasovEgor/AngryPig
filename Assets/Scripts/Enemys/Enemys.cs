using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public abstract class Enemys : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    private float _speedTMP;
    [SerializeField] private Sprite[] _enemySprites;
    [SerializeField] private Sprite[] _dirtyEnemySprites;
    private Sprite[] _currentEnemySprites;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    protected AIPath _AIPath;

    [SerializeField] private HealthUI _healthUI;

    
    public Sprite[] GetSprites()
    {
        return _currentEnemySprites;
    }
    public void SetCurrentSprites(Sprite newSprite)
    {
        _spriteRenderer.sprite = newSprite;
    }
    public float GetSpeed()
    {
        return _speed;
    }
    public int GetEnemysHealth()
    {
        return _health;
    }
    public void SetEnemysHealth(int newHealth)
    {
       _health = newHealth; 
    }
    private void Start()
    {
        _AIPath = GetComponent<AIPath>();
        _AIPath.maxSpeed = GetSpeed();
        _healthUI.Setup(_health);
        _speedTMP = _speed;
        _currentEnemySprites = _enemySprites;
    }
    public void DirtyEnemys()
    {
        _currentEnemySprites = _dirtyEnemySprites;
        _speed = 0;
        _AIPath.maxSpeed = _speed;
        Invoke("ClearningEnemys", 1.5f);
        
    }

    private void ClearningEnemys()
    {
        _currentEnemySprites = _enemySprites;
        _speed = _speedTMP;
        _AIPath.maxSpeed = _speed;
    }
}
