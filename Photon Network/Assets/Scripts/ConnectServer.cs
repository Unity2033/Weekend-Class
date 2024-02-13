using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Realtime;

public class ConnectServer : MonoBehaviourPunCallbacks
{
    [SerializeField] Canvas canvasRoom;
    [SerializeField] Canvas canvasLobby;
    [SerializeField] TMP_Dropdown server;

    private void Awake()
    {
        server.options[0].text = "Asia";
        server.options[1].text = "Europe";
        server.options[2].text = "America";

        if(PhotonNetwork.IsConnected)
        {
            canvasLobby.gameObject.SetActive(false);
        }
    }

    public void SelectServer()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnJoinedLobby()
    {
        canvasRoom.sortingOrder = 1;
    }

    public override void OnConnectedToMaster()
    {
        // JoinLobby : 특정 로비를 생성하여 진입하는 방법
        PhotonNetwork.JoinLobby
        (
            new TypedLobby
            (
                server.options[server.value].text,
                LobbyType.Default
            )
        ); 
    }
}
