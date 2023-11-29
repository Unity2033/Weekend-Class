using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Monster
{
    protected override void Attack()
    {
        speed = 0;
        attack = 10f;
        health = 75f;

        animator.SetBool("Attack", true);
    }

    protected override void Death()
    {
        Debug.Log("Die");
    }
}
