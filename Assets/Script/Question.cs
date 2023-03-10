using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    int [] data = new int[] { 4, 1, 2, 3, 9, 7, 8, 6, 10, 5};

    string content = "Single";

    int count = 0;

    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Debug.Log(data[i]);
        } 
    }
}
