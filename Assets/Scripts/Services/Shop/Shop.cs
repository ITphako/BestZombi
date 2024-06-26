using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 ﻿using System;

public class Shop : MonoBehaviour, IInjectServices, IShopBue
{ 
    public int ScoreCount;
     [SerializeField] private StarBar _starBar;
   [SerializeField] private List<Weapon> _weapons;
   [SerializeField] private List<GameObject> _images;
   public int _startNumber;
   public int _listNumber; 
   public int _lateNumberTwo;
   public int _oneNumberSave;
   public int _twoNumberSave; 
   [SerializeField] private UnLock _unLock;
   [SerializeField] private GameObject effect;
   [SerializeField] private Transform spawn;
   [SerializeField] private Transform spawnTwo;
   [SerializeField] private Transform spawnThree;
    [SerializeField] private ShopClick _music;
    [SerializeField] private Score _score;
   
    private IWeaponView _weaponView;
    private ICurrencyVault _currencyVault;
    private ICurrencyVaultState _currencyVaultState;
    private ICurrencyView _currencyView;
    private IStarAnim _starAnim;
    private ILevelUp _levelUp;
    
    private bool _check => _startNumber !=_lateNumberTwo;
    
    public event Action OnStarUp;
    public bool isSave = false;
    public bool isSaveOne = false;

    public GameObject _bag;
    
     [SerializeField] private float _time;
     [SerializeField] private float _spawnDelay;


     public void InjectServices(IServiceLocator serviceLocator)
        {
            _weaponView = serviceLocator.GetService<IWeaponView>();
            _currencyVault = serviceLocator.GetService<ICurrencyVault>();
            _currencyVaultState = serviceLocator.GetService<ICurrencyVaultState>();
            _currencyView = serviceLocator.GetService<ICurrencyView>();
            _starAnim = serviceLocator.GetService<IStarAnim>();
            _levelUp = serviceLocator.GetService<ILevelUp>();
        }

        private void Start()
        {
          if(_startNumber == 0)
            ActiveGameObject();
          
             if(isSave == true)
        ActiveGameObjectSave(_oneNumberSave);

         if(isSaveOne == true)
       AddItem(_weapons[_oneNumberSave],_images[_twoNumberSave]);

        }

   
    private void Update() 
    {
        if(_startNumber == _weapons.Count - _listNumber && _check)
        {
            ActiveGameObject();
            AddItem(_weapons[_startNumber],_images[_startNumber]);
            
            NextItem();
            _oneNumberSave++;
            _twoNumberSave++;
            if(_startNumber == 1)
            {
              isSave = true;
              isSaveOne = true;
            }
        }
        StopAnimBag();

    }

    public void StopAnimBag()
    {
      if(_weaponView.GetWeaponPriceDouble() > _currencyVaultState.CurrentCountDouble)
        {
           _starAnim.StopAnim();
        }
    }

   private void  ActiveGameObject()
    {
      _images[_startNumber].SetActive(true);
    }

private void  DiactiveGameObject()
    {
      _images[_startNumber].SetActive(false);
    }


    private void  ActiveGameObjectSave(int numbert)
    {
      _images[numbert].SetActive(true);
    }

     private void AddItem(Weapon weapon, GameObject image)
    {
        _weaponView.Render(weapon,image);

    }

     private void AddItemTwo(Weapon weapon)
    {
        _weaponView.Render(weapon);
    }


    private void NextItem()
    {
            _lateNumberTwo = _startNumber;
    }

    public void TrySellWeapon(Weapon weapon)
    {
        if (_weaponView.GetWeaponPriceDouble() <= _currencyVaultState.CurrentCountDouble)
        {
            _currencyVaultState.CurrentCountDouble -= _weaponView.GetWeaponPriceDouble();
            _currencyView.OnChangeCurrency( _currencyVaultState.CurrentCountDouble);
            DiactiveGameObject();
            _startNumber++;
            _listNumber--;
            OnStarUp?.Invoke();
           _starAnim.StopAnim();
           _starBar.IsGo();
           _levelUp.LevelBue();
           _unLock.IsReady();
           Instantiate(effect, spawn.position, Quaternion.identity);
           Instantiate(effect, spawnTwo.position, Quaternion.identity);
           Instantiate(effect, spawnThree.position, Quaternion.identity);
           _music.PlayMusic();
           _score.SetScore();

           ScoreCount++;
        }
    }
}
