using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Monster
{
    protected override void Attack()
    {
        speed = 0;

        animator.SetBool("Attack", true);
    }

    protected override void Death()
    {
        Debug.Log("Die");
    }
}
