
using UnityEngine;

public class ShopView : MonoBehaviour
{
    [SerializeField] private GameObject _shop;

     public void OpenShop()
    {
       _shop.SetActive(true);
    }

     public void CloseShop()
    {
       _shop.SetActive(false);
    }
}
