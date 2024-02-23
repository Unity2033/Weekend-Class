using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonPlayer : MonoBehaviourPun, IPunObservable
{
    [SerializeField] float score;
    [SerializeField] float speed;
    [SerializeField] float mouseX;
    [SerializeField] float rotateSpeed;

    [SerializeField] Vector3 direction;
    [SerializeField] Camera temporaryCamera;

    void Start()
    {
        // 현재 플레이어가 나 자신이라면?
        if(photonView.IsMine)
        {
            Camera.main.gameObject.SetActive(false);
        }
        else
        {
            temporaryCamera.enabled = false;
            GetComponentInChildren<AudioListener>().enabled = false;
        }    
    }

    void Update()
    {
        if (photonView.IsMine == false) return;
        
        Movement();

        Rotation();
    }

    public void Movement()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        // TransformDirection : 자기가 바라보고 있는 방향으로 이동하는 함수입니다.
        transform.position += transform.TransformDirection(direction) * speed * Time.deltaTime;
    }

    public void Rotation()
    {
        mouseX += Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime;

        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        // 로컬 오브젝트라면 쓰기 부분을 실행합니다.
        if(stream.IsWriting)
        {
            // 네트워크를 통해 데이터를 보냅니다.
            stream.SendNext(score);
        }
        else // 원격 오브젝트라면 읽기 부분을 실행합니다.
        {
            // 네크워크를 통해서 데이터를 받습니다.
            score = (float)stream.ReceiveNext();
        }
    }
}
