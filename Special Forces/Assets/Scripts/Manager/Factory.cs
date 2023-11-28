using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    private Monster unit;

    [SerializeField] Transform [ ] spawnPosition;

    public Monster CreateUnit(Monster unitType)
    {
          // 게임 오브젝트를 생성합니다.
          unit = Instantiate(unitType);

          // 게임 오브젝트의 위치를 설정합니다.
          unit.transform.position = spawnPosition[Random.Range(0, spawnPosition.Length)].position;

          // 게임 오브젝트를 반환합니다.
          return unit;
    }
}
