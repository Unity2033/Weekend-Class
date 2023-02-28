using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public static GameEvent instance;

    public event Action<int> onDoorExit;
    public event Action<int> onDoorEnter;
  
    private void Awake()
    {
        instance = this;
    }

    public void DoorTriggerEnter(int enterCount)
    {
        if(onDoorEnter != null)
        {
            onDoorEnter(enterCount);
        }
    }

    public void DoorTriggerExit(int exitCount)
    {
        if (onDoorExit != null)
        {
            onDoorExit(exitCount);
        }
    }
}
