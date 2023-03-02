using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;
    [SerializeField] int count;

    void Start()
    {
        animator = GetComponent<Animator>();

        GameEvent.instance.onDoorEnter += OpenDoor;
        GameEvent.instance.onDoorExit += CloseDoor;
    }

    private void OpenDoor(int openCount)
    {
        if (openCount == count)
        {      
            animator.SetBool("Open",true);
        }
    }

    private void CloseDoor(int closeCount)
    {
        if (closeCount == count)
        {
            animator.SetBool("Open", false);
        }
    }
}
