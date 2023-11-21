using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    private Material originMaterial;
    private SpriteRenderer spriteRenderer;

    [SerializeField] float speed = 250;
    [SerializeField] Vector2 direction;
    [SerializeField] Material flashMaterial;

    private WaitForSeconds waitForSeconds = new WaitForSeconds(0.125f);

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        originMaterial = spriteRenderer.material;
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Flash());
        }
    }

    private void FixedUpdate()
    {
        // 이동 관련 함수
        Move();
        
        // 상태 전환 함수
        State();
    }

    public void Move()
    {
        rigidbody2D.velocity = direction.normalized * speed * Time.fixedDeltaTime; 
    }

    public void State()
    {
        if(rigidbody2D.velocity == Vector2.zero)
        {
            animator.SetBool("Walk", false);
        }
        else
        {
            InvertImage();

            animator.SetBool("Walk", true);
        }
    }

    public void InvertImage()
    {
        if(direction.x > 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(direction.x < 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    // 코루틴 함수 Flash
    public IEnumerator Flash()
    {
        spriteRenderer.material = flashMaterial;

        yield return waitForSeconds;

        spriteRenderer.material = originMaterial;
    }
}
