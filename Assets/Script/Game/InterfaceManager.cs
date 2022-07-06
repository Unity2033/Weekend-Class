using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    public GameObject window;

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }
   
    public void ActiveUI()
    {
        window.SetActive(true);
    }

}
