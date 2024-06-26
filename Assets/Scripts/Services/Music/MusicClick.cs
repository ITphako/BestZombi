using UnityEngine;
﻿using System;

public class MusicClick : MonoBehaviour,IInjectServices
{
   [SerializeField] private AudioSource _music;
   [SerializeField] private GameObject _musicOne;
   [SerializeField] private GameObject _musicTwo;
[SerializeField] private ShopClick _bonk;

    private bool isEnadle = true;
   private IClicer _clicer;

    public void InjectServices(IServiceLocator serviceLocator)
        {
           _clicer  = serviceLocator.GetService<IClicer>();
           _clicer.OnChange += Changed;
        }

   private void Changed()
   {
     _music.Play();
   }

 public void EnableMusic()
    {
        if (isEnadle)
        {
            _bonk.PlayMusic();
            _music.enabled = false;
            isEnadle = false;
            _musicOne.SetActive(false);
            _musicTwo.SetActive(true);
        }
        
    }

     public void DisableMusic()
     {
        if(isEnadle == false)
        {
            _bonk.PlayMusic();
            
          _music.enabled = true;
            isEnadle = true;
            _musicOne.SetActive(true);
            _musicTwo.SetActive(false);
        }
     }
}
