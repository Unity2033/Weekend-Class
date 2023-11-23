using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;

    [SerializeField] Vector2 direction;
    [SerializeField] float speed = 100f;
    [SerializeField] Transform characterPosition;

    protected virtual void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        characterPosition = GameObject.Find("Character").transform;
    }

    protected virtual void Update()
    {
        direction = (Vector2)characterPosition.position - (Vector2)transform.position;
    }

    protected virtual void FixedUpdate()
    {   
        rigidbody2D.velocity = direction.normalized * speed * Time.fixedDeltaTime;

        InvertImage();
    }

    public void InvertImage()
    {
        spriteRenderer.flipX = (direction.x < 0) ? true : false;
    }

    protected abstract void Attack();
}
