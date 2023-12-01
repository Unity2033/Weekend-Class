using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Monster
{
    public void Start()
    {
        base.Start();

        health = 75f;
    }

    protected override void Attack()
    {
        attack = 10f;

        animator.SetBool("Attack", true);
    }

    protected override void Death()
    {
        animator.Play(typeof(Bat) + " " + "Die");
    }
}
