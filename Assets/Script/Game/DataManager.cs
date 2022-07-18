using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Information
{
    public int price;
    public Sprite sprite;
}


public class DataManager : MonoBehaviour
{
    public Information [] information;

    public Text [] priceText;
    public Image [] shapeImage;

    void Start()
    {
        for (int i = 0; i < information.Length; i++)
        {
            priceText[i].text = information[i].price.ToString();
            shapeImage[i].sprite = information[i].sprite;
        }
    }

    public void Purchase(int index)
    {
        if (GameManager.instance.coin >= information[index].price)
        {
            GameManager.instance.coin -= information[index].price;
            GameManager.instance.Save();
        }
    }

}
