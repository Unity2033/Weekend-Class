using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] int count;

    void Start()
    {
        GameEvent.instance.onDoorEnter += OpenDoor;
        GameEvent.instance.onDoorExit += CloseDoor;
    }

    private void OpenDoor(int openCount)
    {
        if (openCount == count)
        {
            transform.position = new Vector3
            (
                transform.position.x,
                3f,
                transform.position.z
            );
        }
    }

    private void CloseDoor(int closeCount)
    {
        if (closeCount == count)
        {
            transform.position = new Vector3
            (
                transform.position.x,
                1.0f,
                transform.position.z
            );
        }
    }
}
