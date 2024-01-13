using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;

    public void Run()
    {
        // SetTrigger("Run") : parameter 조건에 있는 Trigger 발동하는 함수입니다.
        animator.SetTrigger("Run");
    }
}
