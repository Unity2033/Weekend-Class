using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("Create", 5, 5);
    }

    public void Create()
    {
        if(GameManager.instance.state == false) return;

        ObjectPool.Instance.GetQueue();
    }
}
