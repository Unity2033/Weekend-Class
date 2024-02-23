using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviourPunCallbacks
{
    [SerializeField] InputField inputField;
    [SerializeField] Transform contentTransform;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if (inputField.text.Length == 0)
            {
                inputField.ActivateInputField();
                return;
            }

            string chatting = PhotonNetwork.NickName + " : " + inputField.text;

            //  photonView.RPC의 첫 번째 매개변수 : 실행시킬 함수의 이름
            //  photonView.RPC의 두 번째 매개변수 : 호출할 함수를 받을 수 있는 대상을 지정합니다.
            //  photonView.RPC의 세 번째 매개변수 : 실행할 함수의 매개변수

            photonView.RPC("Chatting", RpcTarget.All, chatting);
        }
    }

    [PunRPC]
    public void Chatting(string message)
    {
        GameObject content = Instantiate(Resources.Load<GameObject>("String"));

        content.GetComponent<Text>().text = message;

        content.transform.SetParent(contentTransform);

        inputField.text = "";
    }
}
