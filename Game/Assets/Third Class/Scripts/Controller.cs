using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 direction;

    void Start()
    {
        // transform.position : 게임 오브젝트의 현재 위치를 의미합니다.
        Debug.Log(transform.position);
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // 벡터의 정규화
        direction.Normalize();

        // Time.deltaTime : 프레임 간 이동 사이의 시간 간격
        transform.position = transform.position + direction * speed * Time.deltaTime; 
    }
}
