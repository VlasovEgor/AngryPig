using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СhangingsSprites : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _playerSprite;
    [SerializeField] private Sprite[] _clearObjectSprites;
    [SerializeField] private Sprite[] _dirtyObjectSprites;
    [SerializeField] private TargetMove _targetMove;
    public bool BombDamage=false;



    private void Update()
    {
        if(_targetMove.InputVector.x!=0|| _targetMove.InputVector.y!=0)
        {
            ChangingSpritesFromDirection(SelectingArraySprites(),_targetMove.InputVector);
        }
    }

    private void ChangingSpritesFromDirection(Sprite[] pigSprites, Vector2 moveDirection)
    {
        if(moveDirection.x==1 && moveDirection.y == 0)
        {
            _playerSprite.sprite = pigSprites[0];
        }
        if (moveDirection.x == 0 && moveDirection.y == -1)
        {
            _playerSprite.sprite = pigSprites[1];
        }
        if (moveDirection.x == -1 && moveDirection.y == 0)
        {
            _playerSprite.sprite = pigSprites[2];
        }
        if (moveDirection.x == 0 && moveDirection.y == 1)
        {
            _playerSprite.sprite = pigSprites[3];
        }
    }
    private Sprite[] SelectingArraySprites()
    {
        if (BombDamage)
        {
            Invoke("ClearningPigs", 0.5f);
            return _dirtyObjectSprites;
        }
        else
        {
            return _clearObjectSprites;
        }
        
    }

    private void ClearningPigs()
    {
        BombDamage = false;
    }

}
