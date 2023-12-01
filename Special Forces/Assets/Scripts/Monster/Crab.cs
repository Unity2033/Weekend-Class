using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : Monster
{
    public void Start()
    {
        base.Start();

        health = 100f;
    }

    protected override void Attack()
    {
        attack = 15f;

        animator.SetBool("Attack", true);
    }

    protected override void Death()
    {
        animator.Play(typeof(Crab) + " " + "Die");
    }
}
