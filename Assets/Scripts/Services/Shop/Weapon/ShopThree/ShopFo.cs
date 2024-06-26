using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
 ﻿using System;

public class ShopFo : MonoBehaviour, IInjectServices, IShopBue
{ 
     [SerializeField] private StarBar _starBar;
   [SerializeField] private List<Weapon> _weapons;
   public int _startNumber;
   public int _listNumber;
   public int _lateNumberTwo;
    [SerializeField] private WeaponViewFo _weaponView;
    [SerializeField] private ShopClick _music;
   
    private ICurrencyVault _currencyVault;
    private ICurrencyVaultState _currencyVaultState;
    private ICurrencyView _currencyView;
    private IStarAnim _starAnim;
    
    private bool _check => _startNumber !=_lateNumberTwo;
    
    public event Action OnStarUp;
    public bool isSave = false;
   public int _oneShopTwo;

     public void InjectServices(IServiceLocator serviceLocator)
        {
            _currencyVault = serviceLocator.GetService<ICurrencyVault>();
            _currencyVaultState = serviceLocator.GetService<ICurrencyVaultState>();
            _currencyView = serviceLocator.GetService<ICurrencyView>();
            _starAnim = serviceLocator.GetService<IStarAnim>();
        }

       private void Start()
        {
         if(isSave == true)
       AddItem(_weapons[_oneShopTwo]);
        }
   
   
    private void Update()
    {
        if(_startNumber == _weapons.Count - _listNumber && _check)
        {
            AddItem(_weapons[_startNumber]);
            NextItem();
            _oneShopTwo++;
        }
    }
    
    public void Change()
    {
         AddItem(_weapons[_startNumber]);
    }


     private void AddItem(Weapon weapon)
    {
        _weaponView.Render(weapon);
    }

    private void NextItem()
    {
            _lateNumberTwo = _startNumber;
    }

    public void TrySellWeapon(Weapon weapon)
    {
        if (_weaponView.GetWeaponPrice() <= _currencyVaultState.CurrentCountDouble)
        {
            _currencyVaultState.CurrentCountDouble -= _weaponView.GetWeaponPrice();
            _currencyView.OnChangeCurrency( _currencyVaultState.CurrentCountDouble);
            _startNumber++;
            _listNumber--;
            OnStarUp?.Invoke();
           _starAnim.StopAnim();
           _starBar.IsGo();
           _music.PlayMusic();
        }
    }
}
