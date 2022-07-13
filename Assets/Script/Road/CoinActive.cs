using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinActive : MonoBehaviour
{
    public GameObject [] coin;

    private void Start()
    {
        coin[Random.Range(0, 3)].SetActive(true);       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            for (int i = 0; i < coin.Length; i++)
            {
                coin[i].SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            coin[Random.Range(0, 3)].SetActive(true);
        }
    }

  


}
