using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] Monster monsterPrefab;
    [SerializeField] Transform [ ] spawnPosition;

    private readonly WaitForSeconds waitForSeconds = new WaitForSeconds(3);

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            yield return waitForSeconds;

            Instantiate(monsterPrefab, spawnPosition[Random.Range(0, spawnPosition.Length)]);
        }
    }
}
