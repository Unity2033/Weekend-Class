using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    public static InterfaceManager instance;

    public GameObject window;
    public Text coinText;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        coinText.text = "$ " + GameManager.instance.coin.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Appliaction.Quit();
#endif
    }
   
    public void ActiveUI()
    {
        window.SetActive(true);
    }

}
