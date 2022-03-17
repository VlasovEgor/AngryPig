using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemysSprites : MonoBehaviour
{
    [SerializeField] private AIPath _aIPath;
    [SerializeField] private Enemys _enemys;

    private void Update()
    {
        CheckingDirection();
    }

    private void CheckingDirection()
    {
        if (_aIPath.desiredVelocity.x >= 0.01f)
        {
            SwapSprites(_enemys.GetSprites()[0]);
        }
        else
        {
            SwapSprites(_enemys.GetSprites()[2]);
        }
        if (_aIPath.desiredVelocity.x < _aIPath.desiredVelocity.y && _aIPath.desiredVelocity.y >= 0.01f)
        {
            SwapSprites(_enemys.GetSprites()[3]);
        }
        else if (_aIPath.desiredVelocity.x > _aIPath.desiredVelocity.y && _aIPath.desiredVelocity.y <= 0.01f)
        {
            SwapSprites(_enemys.GetSprites()[1]);
        }
    }

    private void SwapSprites(Sprite newSprite)
    {
        _enemys.SetCurrentSprites(newSprite);
    }
}
