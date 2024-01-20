using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }

}
