using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : Monster
{
    protected override void Attack()
    {
        speed = 0;
        attack = 15f;
        health = 100f;

        animator.SetBool("Attack", true);
    }

    protected override void Death()
    {
        throw new System.NotImplementedException();
    }
}
