using System;
using UnityEngine;

public class Clicer : MonoBehaviour, IClicer,IInjectServices
{
   [SerializeField] private GameObject effect;
    public double _power;
    private ICurrencyVault _currencyVault;
    private IShopBue _shop;
    private IWeaponView _weaponView;

    public event Action OnChange;

     public void InjectServices(IServiceLocator serviceLocator)
        {
           _currencyVault  = serviceLocator.GetService<ICurrencyVault>();
           _shop  = serviceLocator.GetService<IShopBue>();
            _weaponView = serviceLocator.GetService<IWeaponView>();

           _shop.OnStarUp += ChangePower;
        }

    public void AddPower()
   {
    _currencyVault.ChangeCurrency(_power);
    OnChange.Invoke();
           Instantiate(effect, transform.position, Quaternion.identity);
   }

   private void ChangePower()
   {
    _power += _weaponView.GetWeaponPowerDouble();
   }
}
