using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : IEnumerator
{
    private int index = -1;
    private int [ ] bullet;

    public Rifle()
    {
        bullet = new int[5];
    }

    // Current : 읽기 전용 프로퍼티로 현재 위치의 데이터를 object 타입으로 반환합니다.
    public object Current
    {
        get { return bullet[index]; }
    }
    
    // MoveNext : 다음 위치로 이동하는데 다음 위치에 데이터가 있으면 true 값을 반환하고
    //            없으면 false 값을 반환합니다.
    public bool MoveNext()
    {
        index++;

        return index < bullet.Length;
    }

    // Reset : 인덱스를 초기 상태 위치로 이동시킵니다.
    //         Index를 -1로 초기화합니다.
    public void Reset()
    {
        index = -1;
    }
}

public static class CoroutineCache 
{
    class FloatCompare : IEqualityComparer<float>
    {
        public bool Equals(float x, float y)
        {
            return x == y;
        }

        public int GetHashCode(float obj)
        {
            return obj.GetHashCode();
        }
    }

    private static readonly Dictionary<float, WaitForSeconds> timeInterval = new Dictionary<float, WaitForSeconds>(new FloatCompare());

    public static WaitForSeconds waitForSeconds(float time)
    {
        WaitForSeconds waitForSeconds;

        if (timeInterval.TryGetValue(time,out waitForSeconds) == false)
        {
            timeInterval.Add(time, waitForSeconds = new WaitForSeconds(time));
        }

        return waitForSeconds;
    }
}
