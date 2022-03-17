using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnCollison : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<Player>())
            {
                collision.rigidbody.GetComponent<ChangePlayerHealth>().TakeDamage(5);
            }
        }
    }
}
