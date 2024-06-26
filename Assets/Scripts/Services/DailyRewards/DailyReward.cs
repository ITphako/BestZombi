using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System;
using System.Globalization;
using Cysharp.Threading.Tasks;

public class DailyReward : MonoBehaviour,IInjectServices
{
    public TMP_Text _currencyText;
    public int Onnnne = 1;
    public int Twooooo = 2;
    public int Threeeeee = 3;
    public int day_of_week;
    public int _lastReciveBonus;
    public int _dayInRow;

    public bool isNetworkError;
    public bool isHttpError;
    public bool isLoaded;
    public bool isCompleteLoaded;
    public bool isRewardGet;

 private const string SERVER_URI = "https://worldtimeapi.org/api/timezone/Europe/Moscow";

    public GameObject _unlock;
    public GameObject[] _unlocks;
    public ShopClick _bonk;
   public int _dayBonus;
   public Bonus _bonus;
    public bool isSave = false;
    public bool isSaveOne = false;
    public bool isSaveTwo = false;
    public bool isSaveThree = false;
    public bool isSaveFo = false;
    public bool isSaveFive = false;
    public bool isSaveSix = false;
   public int _oneNumberSave;
       public ChestAnim _anim;

    private ICurrencyVault _currencyVault;
    
 public void InjectServices(IServiceLocator serviceLocator)
        {
           _currencyVault  = serviceLocator.GetService<ICurrencyVault>();
        }
        private void Start()
        {
          
               SendRequest().Forget();
               
             if(isSave == true)
        ActiveGameObject(0);
             if(isSaveOne == true)
        ActiveGameObject(1);
             if(isSaveTwo == true)
        ActiveGameObject(2);
             if(isSaveThree == true)
        ActiveGameObject(3);
             if(isSaveFo == true)
        ActiveGameObject(4);
             if(isSaveFive == true)
        ActiveGameObject(5);
             if(isSaveSix == true)
        ActiveGameObject(6);
        }

         private void  ActiveGameObject(int number)
    {
      _unlocks[number].SetActive(true);
    }

    private void DiactiveGameObject()
    {
            isSave = false;
            isSaveOne = false;
            isSaveTwo = false;
            isSaveThree = false;
            isSaveFo = false;
            isSaveFive = false;
            isSaveSix = false;
    }

   
        private  async UniTask SendRequest()
        {
            try
            {
                using UnityWebRequest webRequest = UnityWebRequest.Head(Application.absoluteURL);
                webRequest.SetRequestHeader("cache-control", "no-cache");
                await webRequest.SendWebRequest();

                switch (webRequest.result)
                {
                    case UnityWebRequest.Result.ConnectionError:
                        isNetworkError = true;
                        isLoaded = true;
                        Debug.Log($"[DailyRewardYandexService] => Network Error! -> {webRequest.error}");
                        break;
                    case UnityWebRequest.Result.DataProcessingError:
                        isHttpError = true;
                        isLoaded = true;
                        Debug.Log($"[DailyRewardYandexService] => Data Processing Error! -> {webRequest.error}");
                        break;
                    case UnityWebRequest.Result.ProtocolError:
                        isHttpError = true;
                        isLoaded = true;
                        Debug.Log($"[DailyRewardYandexService] => Protocol Error! -> {webRequest.error}");
                        break;
                    case UnityWebRequest.Result.Success:
                       string dateString   = webRequest.GetResponseHeader("date");

                         DateTimeOffset dateValue = DateTimeOffset.Parse(dateString, 
                            CultureInfo.InvariantCulture, 
                            DateTimeStyles.AssumeUniversal);

                            
                         day_of_week = (int) dateValue.DayOfWeek;

                        isCompleteLoaded = true;
                        isLoaded = true;
                        break;
                }
            }
            catch (Exception)
            {
                isNetworkError = true;
                isLoaded = true;
                throw;
            }
        }

            
            public void Init(int number)
            {
                if(number == 1)
                {
                    _bonk.PlayMusic();
                    _unlocks[0].SetActive(true);
                      _dayInRow++;
    _currencyVault.ChangeCurrency(1000);
    isSave = true;
                }
                if(number == 2)
                {
                    _bonk.PlayMusic();
                    _unlocks[1].SetActive(true);
                      _dayInRow++;
    _currencyVault.ChangeCurrency(5000);
    isSaveOne = true;
                }
                if(number == 3)
                {
                    _bonk.PlayMusic();
                    _unlocks[2].SetActive(true);
                      _dayInRow++;
    _currencyVault.ChangeCurrency(10000);
    isSaveTwo = true;
                }
                if(number == 4)
                {
                    _bonk.PlayMusic();
                    _unlocks[3].SetActive(true);
                      _dayInRow++;
    _currencyVault.ChangeCurrency(20000);
    isSaveThree = true;
                }
                if(number == 5)
                {
                    _bonk.PlayMusic();
                    _unlocks[4].SetActive(true);
                      _dayInRow++;
    _currencyVault.ChangeCurrency(30000);
    isSaveFo = true;
                }
                if(number == 6)
                {
                    _bonk.PlayMusic();
                    _unlocks[5].SetActive(true);
                      _dayInRow++;
    _currencyVault.ChangeCurrency(40000);
    isSaveFive = true;
                }
                if(number == 7)
                {
                    _bonk.PlayMusic();
                    _unlocks[6].SetActive(true);
                      _dayInRow++;
    _currencyVault.ChangeCurrency(50000);
    isSaveSix = true;
                }
                
            }

            private void Update()
            {
                if(day_of_week != _lastReciveBonus)
                {
                     _lastReciveBonus = day_of_week;
                     isRewardGet = false;
                    _bonus._bonusCount++;
                    _anim.isStart = true;
                }

                if(_bonus._bonusCount == 8)
                {
                     for(int i = 0; i < _unlocks.Length; i++)
                     {
                    _unlocks[i].SetActive(false);
                     }
                     _bonus._bonusCount = 1;
                     isRewardGet = false;
                     DiactiveGameObject();
                }
            }
}
