using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected int attack;
    [SerializeField] protected float speed;

    public abstract void Attack();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Monster monster = collision.GetComponent<Monster>();

        if(monster != null)
        {
            StartCoroutine(monster.OnHit(attack));
        }
    }
}
