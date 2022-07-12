using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
    private int value;
    public GameObject [] tireStack;

    void Start()
    {
        value = Random.Range(0, 3);

        for(int i = 0; i < tireStack.Length; i++)
        {     
            tireStack[i].SetActive(false);
        }
       
        tireStack[value].SetActive(true);     
    }

    void Update()
    {
        if (GameManager.instance.state == false) return;

        transform.Translate(Vector3.back * GameManager.instance.speed * Time.deltaTime);

        if (transform.position.z <= -10f)
        {
            gameObject.transform.position = new Vector3(0, 0.1f, 7.5f);
            ObjectPool.Instance.InsertQueue(gameObject);
        }
    }
}
