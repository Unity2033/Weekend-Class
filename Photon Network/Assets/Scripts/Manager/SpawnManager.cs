using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviourPunCallbacks
{
    WaitForSeconds waitForSeconds = new WaitForSeconds(5f);

    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            StartCoroutine(SpawnObject());
        }      
    }

    public Vector3 RandomPosition(float distance)
    {
        Vector3 direction = Random.insideUnitSphere;

        direction.Normalize();

        direction = direction * distance;

        direction.y = 0;

        return direction;
    }

    public IEnumerator SpawnObject()
    {
        while(true)
        {
            PhotonNetwork.InstantiateRoomObject("Metalon", RandomPosition(15), Quaternion.identity);

            yield return waitForSeconds;
        }
    }
  
}
