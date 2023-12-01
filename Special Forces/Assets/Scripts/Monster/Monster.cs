using System.Collections;
using UnityEngine;

public enum STATE
{
    WALK,
    ATTACK,
    HIT,
    DIE
}

public abstract class Monster : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private protected Animator animator;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private float power = 10;

    [SerializeField] STATE state;
    [SerializeField] Vector2 direction;
    [SerializeField] Transform characterPosition;

    [SerializeField] protected float attack;
    [SerializeField] protected float health;
    [SerializeField] protected float speed = 100f;

    [SerializeField] Sound sound = new Sound();

    protected void Start()
    {
        animator = GetComponent<Animator>();
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
        switch(state)
        {
            case STATE.WALK : Move();
                break;
            case STATE.ATTACK : Attack();
                break;
            case STATE.HIT :  
                break;
            case STATE.DIE : Death(); 
                break;
        }
    }

    public void InvertImage()
    {
        spriteRenderer.flipX = (direction.x < 0) ? true : false;
    }

    protected void Move()
    {
        animator.SetBool("Attack", false);

        rigidbody2D.velocity = direction.normalized * speed * Time.fixedDeltaTime;

        InvertImage();
    }

    public void Damage()
    {
        characterPosition.GetComponent<Character>().OnHit(attack);
    }

    public IEnumerator OnHit(float damage)
    {
        state = STATE.HIT;

        rigidbody2D.velocity = Vector2.zero;

        health -= damage;

        AudioManager.instance.Sound(sound.audioClip[0]);

        if(health <= 0)
        {
            state = STATE.DIE;

            yield break;
        }

        rigidbody2D.AddForce(-direction * power, ForceMode2D.Force);

        yield return CoroutineCache.waitForSeconds(0.25f);

        state = STATE.WALK;
    }

    public void Release()
    {
        Destroy(gameObject);
    }

    protected abstract void Attack();

    protected abstract void Death();

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Character"))
        {
            state = STATE.ATTACK;
        }
    }

    protected void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Character"))
        {
            if (state != STATE.DIE)
            {
                state = STATE.WALK;
            }
        }
    }
}
