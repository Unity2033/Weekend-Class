using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    [SerializeField] int n;
    [SerializeField] List<int> array;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Find(array, n);
        }
    }

    void Find(List<int> array, int target)
    {
        int left = 0;
        int right = array.Count - 1;

        while(left <= right)
        {
            // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정합니다.
            int pivot = (left + right) / 2;

            // 2. [pivot]의 값이 찾고자 하는 target 값과 같다면 검색 종료
            if (array[pivot] == target)
            {
                Debug.Log("pivot의 값 : " + array[pivot]);
                return;
            }
            else if (array[pivot] > target) // 3. [pivot]의 값이 찾는 값보다 크다면 left ~ pivot까지 탐색합니다.
            {
                right = pivot - 1;
            }
            else
            {
                left = pivot + 1;
            }
        }

        Debug.Log("값을 찾지 못했습니다.");
    }

}
