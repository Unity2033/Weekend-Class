using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    string content = "CountDown";
    int count = 0;

    void Start()
    {

        for (int i = 0; i < content.Length; i++)
        {
            if (content[i] >= 'A' && content[i] <= 'Z')
            {
                count++;
            }
        }

        Debug.Log(count);
    }
}
