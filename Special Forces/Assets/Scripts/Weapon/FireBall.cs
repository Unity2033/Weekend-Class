using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Weapon
{
    [SerializeField] int offset;
    [SerializeField] Transform character;

    public void Update()
    {
        Attack();
    }

    public override void Attack()
    {
        transform.localPosition = new Vector3
        (
            Mathf.Cos(Time.time * speed) * offset, 
            Mathf.Sin(Time.time * speed) * offset,
            0
        );
    }

}
