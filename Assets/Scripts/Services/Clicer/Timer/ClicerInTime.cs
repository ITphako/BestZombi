using System;
using UnityEngine;
using System.Collections;

public class ClicerInTime : MonoBehaviour,IInjectServices
{
    public double _power;
    [SerializeField] private double _score;
    [SerializeField] private WeaponViewTwo _weaponViewTwo;
    [SerializeField] private WeaponViewThree _weaponViewThree;
    [SerializeField] private WeaponViewFo _weaponViewFo;
    [SerializeField] private WeaponViewFive _weaponViewFive;
    [SerializeField] private WeaponViewSix _weaponViewSix;
     [SerializeField] private ShopTwo _shopTwo;
     [SerializeField] private ShopThree _shopThree;
     [SerializeField] private ShopFo _shopFo;
     [SerializeField] private ShopFive _shopFive;
     [SerializeField] private ShopSix _shopSix;

    private ICurrencyVault _currencyVault;

    public event Action OnChange;

     public void InjectServices(IServiceLocator serviceLocator)
        {
           _currencyVault  = serviceLocator.GetService<ICurrencyVault>();

           _shopTwo.OnStarUp += ChangePowerTwo;
           _shopThree.OnStarUp += ChangePowerThree;
           _shopFo.OnStarUp += ChangePowerFo;
           _shopFive.OnStarUp += ChangePowerFive;
           _shopSix.OnStarUp += ChangePowerSix;
        }

        public void AddPower()
   {
    _currencyVault.ChangeCurrency(_power);
    OnChange.Invoke();
   }

   private void ChangePowerTwo()
   {
    _power += _weaponViewTwo.GetWeaponPower();
   }

   private void ChangePowerThree()
   {
    _power += _weaponViewThree.GetWeaponPower();
   }

   private void ChangePowerFo()
   {
    _power += _weaponViewFo.GetWeaponPower();
   }

   private void ChangePowerFive()
   {
    _power += _weaponViewFive.GetWeaponPower();
   }

   private void ChangePowerSix()
   {
    _power += _weaponViewSix.GetWeaponPower();
   }

   private IEnumerator ShopBue()
   {
    while(true)
    {
       _score += _power;
    _currencyVault.ChangeCurrency(_power);
      yield return new WaitForSeconds(1);
    }
   }

   private void Start()
   {
    StartCoroutine(ShopBue());
   }
}
