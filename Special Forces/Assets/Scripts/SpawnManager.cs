using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] int rand;

    [SerializeField] Factory factory;
 
    [SerializeField] List<Monster> monsterList;
    private readonly WaitForSeconds waitForSeconds = new WaitForSeconds(3);

    private void Start()
    {
        monsterList.Capacity = 10;

        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            yield return waitForSeconds;

            rand = Random.Range(0, monsterList.Count);

            factory.CreateUnit(monsterList[rand]);
        }
    }
}
