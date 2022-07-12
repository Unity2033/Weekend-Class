using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    public GameObject obstacle;

    public Queue<GameObject> queue = new Queue<GameObject>();

    void Start()
    {
        Instance = this;

        for(int i = 0; i < 5; i++)
        {
            GameObject tempPrefab = Instantiate(obstacle, new Vector3(0, 0.1f, 7.5f), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false);
        }
    }

    public void InsertQueue(GameObject prefab)
    {
        queue.Enqueue(prefab);
        prefab.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject tempPrefab = queue.Dequeue();
        tempPrefab.SetActive(true);

        return tempPrefab;
    }
}
