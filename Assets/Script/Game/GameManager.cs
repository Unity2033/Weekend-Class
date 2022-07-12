using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static : 프로그램이 종료될 때까지 메모리에서 살아있습니다.
    // static은 데이터 영역에 저장됩니다.

    public static GameManager instance;

    public float speed;
    public bool state;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        state = true;

        StartCoroutine(SpeedIncrease());
    }

    IEnumerator SpeedIncrease()
    {
        // while 조건이 참이라면 무한 반복하는 반복문입니다.
        while(state)
        {
            // 1초 동안 대기합니다.
            yield return new WaitForSeconds(1f);
            speed++;

            if(state == false)
            {
                speed = 0;
            }

            if(speed >= 50)
            {
                speed = 50;
            }
        }
    }


}
