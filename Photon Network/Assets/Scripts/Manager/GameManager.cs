using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviourPunCallbacks
{
    private int second;
    private int minute;

    [SerializeField] float timer;
    [SerializeField] Text timerText;

    [SerializeField] int playerCount = 3;

    [SerializeField] GameObject nickNamePanel;
    [SerializeField] TMP_InputField nickNameInputField;

    private void Awake()
    {
        CreatePlayer();

        CheckNickName();
    }

    private void Start()
    {
        CheckPlayer();
    }

    private void CreatePlayer()
    {
        PhotonNetwork.Instantiate
        (
            "Player",
            RandomPosition(5),
            Quaternion.identity
        ) ;
    }

    public Vector3 RandomPosition(float distance)
    {
        Vector3 direction = Random.insideUnitSphere;

        direction.Normalize();

        direction = direction * distance;

        direction.y = 1;

        return direction;
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        PhotonNetwork.SetMasterClient(PhotonNetwork.PlayerList[0]);
    }

    public void CreateNickName()
    {
        PlayerPrefs.SetString("Nick Name", nickNameInputField.text);

        PhotonNetwork.NickName = nickNameInputField.text;

        nickNamePanel.SetActive(false);
    }

    public void CheckNickName()
    {
        string nickName = PlayerPrefs.GetString("Nick Name");

        PhotonNetwork.NickName = nickName;

        if (string.IsNullOrEmpty(nickName))
        {
            nickNamePanel.SetActive(true);
        }
        else
        {
            nickNamePanel.SetActive(false);
        }
    }

    public void CheckPlayer()
    {
        Debug.Log(PhotonNetwork.PlayerList.Length);

        if(PhotonNetwork.PlayerList.Length >= playerCount)
        {
            photonView.RPC("RemoteTimer", RpcTarget.All);
        }
    }

    [PunRPC]
    public void RemoteTimer()
    {
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while(true)
        {
            timer -= Time.deltaTime;

            minute = (int)timer / 60;
            second = (int)timer % 60;

            timerText.text = minute.ToString("00") + " : " + second.ToString("00");

            yield return null;

            if(timer <= 0)
            {
                yield break;
            }
        }
    }
}
