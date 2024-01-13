using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportsCar : MonoBehaviour
{
    // 접근 지정자 private 
    // 클래스 내부에서만 사용이 가능한 접근 지정자입니다.
    private float speed = 5.0f;

    // 접근 지정자 protected 
    // 클래스 내부와 자기가 상속하는 클래스에서만 사용이 가능한 접근 지정자입니다.
    protected string name = "Sonata";

    // 접근 지정자 public 
    // 클래스 내부와 클래스 외부에서도 사용이 가능한 접근 지정자입니다.
    public Vector3 direction;
}
