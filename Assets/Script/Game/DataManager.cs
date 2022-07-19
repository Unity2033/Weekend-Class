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
    public Button[] PurchaseButton;

    void Start()
    {
        Debug.Log(GameManager.instance.rod);

        for (int i = 0; i < information.Length; i++)
        {
            priceText[i].text = information[i].price.ToString() + "$";
            shapeImage[i].sprite = information[i].sprite;
        }
    }

    private void Update()
    {
        if(GameManager.instance.hat > 0)
        {
            PurchaseButton[0].interactable = false;
        }
        
        if(GameManager.instance.rod > 0)
        {
            PurchaseButton[1].interactable = false;
        }
    }

    public void Purchase(int index)
    {
        if (GameManager.instance.coin >= information[index].price)
        {
            GameManager.instance.coin -= information[index].price;

            switch(index)
            {
                case 0 : GameManager.instance.hat++;
                    break;
                case 1 : GameManager.instance.rod++;
                    break;
            }

           GameManager.instance.Save();
        }
    }

}
