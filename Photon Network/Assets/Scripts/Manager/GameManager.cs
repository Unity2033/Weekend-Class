using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject nickNamePanel;
    [SerializeField] TMP_InputField nickNameInputField;

    private void Awake()
    {
        CreatePlayer();

        CheckNickName();     
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


}
