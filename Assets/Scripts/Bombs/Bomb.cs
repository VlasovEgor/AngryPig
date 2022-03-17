using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int _bombDamageValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<Player>())
        {
            GameObject player = collision.gameObject;
            DealingDamageToPlayer(player);
        }
        else if (collision.gameObject.GetComponent<Enemys>())
        {
            GameObject enemy = collision.gameObject;
            DealingDamageToEnemy(enemy);
        }
        Destroy(gameObject);
    }

    private void DealingDamageToPlayer(GameObject whoTookDamage)
    {

        whoTookDamage.GetComponent<ÑhangingsSprites>().BombDamage = true;
        whoTookDamage.GetComponent<PlayerMove>().SetSpeed(0);
        whoTookDamage.GetComponent<ChangePlayerHealth>().TakeDamage(_bombDamageValue);


    }
    private void DealingDamageToEnemy(GameObject whoTookDamage)
    {
        whoTookDamage.GetComponent<Enemys>().DirtyEnemys();
        whoTookDamage.GetComponent<TakeDamageEnemys>().TakeDamage(_bombDamageValue);

    }

}
