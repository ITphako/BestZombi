
using UnityEngine;
using System.Collections;

public class MusicOff : MonoBehaviour
{
[SerializeField] private AudioSource BackgroundMusic;
[SerializeField] private GameObject _music;
[SerializeField] private GameObject _musicTwo;
[SerializeField] private ShopClick _bonk;
public WeaponViewTwo _two;
public WeaponViewThree _three;
public WeaponViewFo _fo;
public WeaponViewFive _five;
public WeaponViewSix _six;
public ShopTwo _twoShop;
public ShopThree _threeShop;
public ShopFo _foShop;
public ShopFive _fiveShop;
public ShopSix _sixShop;
    [SerializeField] private string _numberText = "/s";
    [SerializeField] private string _numberTextRus = "/с";
    public bool isSave;
    public bool isSaveOne ;

    private bool isEnadle = true;
    public bool isReady = true;

    private void Start()
    {
        if(isSave == true)
        ChangeLang();
        if(isSaveOne == true)
        ChangeRus();

    }
    public void ChangeLang()
    {
        _two._numberText = _numberText;
        _three._numberText = _numberText;
        _fo._numberText = _numberText;
        _five._numberText = _numberText;
        _six._numberText = _numberText;
        _twoShop.Change();
        _threeShop.Change();
        _foShop.Change();
        _fiveShop.Change();
        _sixShop.Change();
        isSave = true;
        isSaveOne = false;
    }

    public void ChangeRus()
    {
        _two._numberText = _numberTextRus;
        _three._numberText = _numberTextRus;
        _fo._numberText = _numberTextRus;
        _five._numberText = _numberTextRus;
        _six._numberText = _numberTextRus;
        _twoShop.Change();
        _threeShop.Change();
        _foShop.Change();
        _fiveShop.Change();
        _sixShop.Change();
        isSaveOne = true;
        isSave = false;
    }
   
    public void EnableMusic()
    {
        if (isEnadle)
        {
            _bonk.PlayMusic();
            BackgroundMusic.Pause();
            isEnadle = false;
            _music.SetActive(false);
            _musicTwo.SetActive(true);
        }
        
    }

     public void DisableMusic()
     {
        if(isEnadle == false)
        {
            _bonk.PlayMusic();
            BackgroundMusic.UnPause();
            isEnadle = true;
            _music.SetActive(true);
            _musicTwo.SetActive(false);
        }
     }
}
