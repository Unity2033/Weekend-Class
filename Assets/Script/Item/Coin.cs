using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.instance.state == false) return;

        if (other.gameObject.tag == "Character")
        {
            SoundControl.Instance.SoundCall("Coin");
            GameManager.instance.coin += 10;
            gameObject.SetActive(false);
            GameManager.instance.Save();
        }
    }

    // 게임 오브젝트가 비활성화 되었을 때 호출되는 함수입니다.
    private void OnDisable()
    {
        Invoke("Delay", 1f);
    }

    public void Delay()
    {
        gameObject.SetActive(true);
    }
  
}
