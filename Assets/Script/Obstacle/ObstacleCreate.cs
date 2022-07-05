using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    public GameObject obstacle;

    void Start()
    {
        InvokeRepeating("Create", 5, 5);
    }

    public void Create()
    {
        Instantiate(obstacle, new Vector3(0, 0.1f, 7.5f), Quaternion.identity);
    }
}
