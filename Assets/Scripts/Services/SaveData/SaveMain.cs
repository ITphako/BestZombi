
using UnityEngine;
// using YG;

public class SaveMain : MonoBehaviour  //,IInjectServices
{
//    public YandexGame sdk;
//    public float time;
//    public float restart = 3;
//    public Shop _shop;
//    public ShopTwo _shopTwo;
//    public ShopThree _shopThree;
//    public ShopFo _shopFo;
//    public ShopFive _shopFive;
//    public ShopSix _shopSix;
//    public UnLock _unLock;
//    public Clicer _clicker;
//    public ClicerInTime _timer;
//    public DailyReward _dailyReward;
//    public MusicOff _musicOff;
//    public Score _score;

//     private ICurrencyVaultState _currencyVaultState;

//       public void InjectServices(IServiceLocator serviceLocator)
//         {
//            _currencyVaultState  = serviceLocator.GetService<ICurrencyVaultState>();
//         }

//         private void Awake()
// {
//    GetLoad();
// }

//    private void Update()
//    {
//       time += Time.deltaTime;

//       if(time>=restart)
//       {
//     time = 0;
//     Save();
//     _score.TrySaveScrore();
//       }
//    }

//      public void GetLoad()
//         {

//             _currencyVaultState.CurrentCountDouble = YandexGame.savesData.currentCount;
//             _unLock.IsSave =  YandexGame.savesData.isSave;
//             _unLock.IsSaveTwo =  YandexGame.savesData.isSaveUnlockTwo;
//             _unLock.IsSaveThree =  YandexGame.savesData.isSaveUnlockThree;
//             _unLock.IsSaveFo =  YandexGame.savesData.isSaveUnlockFo;
//             _unLock.IsSaveFive =  YandexGame.savesData.isSaveUnlockFive;
//             _unLock.IsSaveSix =  YandexGame.savesData.isSaveUnlockSix;
//             _unLock.IsSaveTwoSave =  YandexGame.savesData.isSave;
//             _shop._startNumber =  YandexGame.savesData.startNumber;
//             _shop._listNumber =  YandexGame.savesData.listNumber;
//             _shop._lateNumberTwo =  YandexGame.savesData.lateNumberTwo;
//             _shop.isSave =  YandexGame.savesData.isSaveShop;
//             _shop.isSaveOne =  YandexGame.savesData.isSaveOne;
//             _shop._oneNumberSave =  YandexGame.savesData.oneNumberSave;
//             _shop._twoNumberSave =  YandexGame.savesData.twoNumberSave;

//             _shopTwo._oneShopTwo =  YandexGame.savesData.oneShopTwo;
//             _shopTwo._startNumber =  YandexGame.savesData.startNumberTwo;
//             _shopTwo._listNumber =  YandexGame.savesData.listNumberTwo;
//             _shopTwo._lateNumberTwo =  YandexGame.savesData.lateNumberTwoTwo;
//             _shopTwo.isSave =  YandexGame.savesData.isSave;
            
//             _shopThree._oneShopTwo =  YandexGame.savesData.oneShopThree;
//             _shopThree._startNumber =  YandexGame.savesData.startNumberhree;
//             _shopThree._listNumber =  YandexGame.savesData.listNumberhree;
//             _shopThree._lateNumberTwo =  YandexGame.savesData.lateNumberTwohree;
//             _shopThree.isSave =  YandexGame.savesData.isSave;
            
//             _shopFo._oneShopTwo =  YandexGame.savesData.oneShopFo;
//             _shopFo._startNumber =  YandexGame.savesData.startNumberFo;
//             _shopFo._listNumber =  YandexGame.savesData.listNumberFo;
//             _shopFo._lateNumberTwo =  YandexGame.savesData.lateNumberTwoFo;
//             _shopFo.isSave =  YandexGame.savesData.isSave;
            
//             _shopFive._oneShopTwo =  YandexGame.savesData.oneShopFive;
//             _shopFive._startNumber =  YandexGame.savesData.startNumberFive;
//             _shopFive._listNumber =  YandexGame.savesData.listNumberFive;
//             _shopFive._lateNumberTwo =  YandexGame.savesData.lateNumberTwoFive;
//             _shopFive.isSave =  YandexGame.savesData.isSave;
            
//              _shopSix._oneShopTwo =  YandexGame.savesData.oneShopSix;
//             _shopSix._startNumber =  YandexGame.savesData.startNumberSix;
//             _shopSix._listNumber =  YandexGame.savesData.listNumberSix;
//             _shopSix._lateNumberTwo =  YandexGame.savesData.lateNumberTwoSix;
//             _shopSix.isSave =  YandexGame.savesData.isSave;
//             _clicker._power = YandexGame.savesData.power;
//             _timer._power = YandexGame.savesData.powerTwo;

            
//             _dailyReward.isSave = YandexGame.savesData.isReward;
//             _dailyReward.isSaveOne = YandexGame.savesData.isRewardOne;
//             _dailyReward.isSaveTwo = YandexGame.savesData.isRewardTwo;
//             _dailyReward.isSaveThree = YandexGame.savesData.isRewardThree;
//             _dailyReward.isSaveFo = YandexGame.savesData.isRewardFo;
//             _dailyReward.isSaveFive = YandexGame.savesData.isRewardFive;
//             _dailyReward.isSaveSix = YandexGame.savesData.isRewardSix;
//             _dailyReward.isRewardGet = YandexGame.savesData.isRewardGet;
//             _dailyReward._bonus._bonusCount = YandexGame.savesData.bonusCount;
//             _dailyReward.day_of_week = YandexGame.savesData.day_of_week;
//             _dailyReward._lastReciveBonus = YandexGame.savesData.lastReciveBonus;
            
//             _musicOff.isSave = YandexGame.savesData.isSaveMusic;
//             _musicOff.isSaveOne = YandexGame.savesData.isSaveMusicOne;

//             _score.HightScore = YandexGame.savesData.HighScore;
//             _score.ScoreCount = YandexGame.savesData.ScoreCount;

//         }

//          public void Save()
//         {
//             YandexGame.savesData.currentCount = _currencyVaultState.CurrentCountDouble;
//             YandexGame.savesData.isSave =    _unLock.IsSave;
//             YandexGame.savesData.isSaveUnlockTwo =    _unLock.IsSaveTwo;
//             YandexGame.savesData.isSaveUnlockThree =    _unLock.IsSaveThree;
//             YandexGame.savesData.isSaveUnlockFo =    _unLock.IsSaveFo;
//             YandexGame.savesData.isSaveUnlockFive =    _unLock.IsSaveFive;
//             YandexGame.savesData.isSaveUnlockSix =    _unLock.IsSaveSix;
//             YandexGame.savesData.startNumber =  _shop._startNumber;
//             YandexGame.savesData.listNumber =  _shop._listNumber;
//             YandexGame.savesData.lateNumberTwo =  _shop._lateNumberTwo;
//             YandexGame.savesData.isSaveShop =  _shop.isSave;
//             YandexGame.savesData.isSaveOne =   _shop.isSaveOne;
//             YandexGame.savesData.oneNumberSave =   _shop._oneNumberSave;
//             YandexGame.savesData.twoNumberSave =   _shop._twoNumberSave;

//             YandexGame.savesData.oneShopTwo =    _shopTwo._oneShopTwo;
//             YandexGame.savesData.startNumberTwo =  _shopTwo._startNumber;
//             YandexGame.savesData.listNumberTwo =  _shopTwo._listNumber;
//             YandexGame.savesData.lateNumberTwoTwo =  _shopTwo._lateNumberTwo;
            
//             YandexGame.savesData.oneShopThree =    _shopThree._oneShopTwo;
//             YandexGame.savesData.startNumberhree =  _shopThree._startNumber;
//             YandexGame.savesData.listNumberhree =  _shopThree._listNumber;
//             YandexGame.savesData.lateNumberTwohree =  _shopThree._lateNumberTwo;
            
//             YandexGame.savesData.oneShopFo =    _shopFo._oneShopTwo;
//             YandexGame.savesData.startNumberFo =  _shopFo._startNumber;
//             YandexGame.savesData.listNumberFo =  _shopFo._listNumber;
//             YandexGame.savesData.lateNumberTwoFo =  _shopFo._lateNumberTwo;
            
//             YandexGame.savesData.oneShopFive =    _shopFive._oneShopTwo;
//             YandexGame.savesData.startNumberFive =  _shopFive._startNumber;
//             YandexGame.savesData.listNumberFive =  _shopFive._listNumber;
//             YandexGame.savesData.lateNumberTwoFive =  _shopFive._lateNumberTwo;
            
//             YandexGame.savesData.oneShopSix =    _shopSix._oneShopTwo;
//             YandexGame.savesData.startNumberSix =  _shopSix._startNumber;
//             YandexGame.savesData.listNumberSix =  _shopSix._listNumber;
//             YandexGame.savesData.lateNumberTwoSix =  _shopSix._lateNumberTwo;
//             YandexGame.savesData.power =   _clicker._power;
//             YandexGame.savesData.powerTwo =   _timer._power;

//             YandexGame.savesData.isReward =   _dailyReward.isSave;
//             YandexGame.savesData.isRewardOne =   _dailyReward.isSaveOne;
//             YandexGame.savesData.isRewardTwo =   _dailyReward.isSaveTwo;
//             YandexGame.savesData.isRewardThree =   _dailyReward.isSaveThree;
//             YandexGame.savesData.isRewardFo =   _dailyReward.isSaveFo;
//             YandexGame.savesData.isRewardFive =   _dailyReward.isSaveFive;
//             YandexGame.savesData.isRewardSix =   _dailyReward.isSaveSix;
//             YandexGame.savesData.isRewardGet =   _dailyReward.isRewardGet;
//             YandexGame.savesData.bonusCount =  _dailyReward._bonus._bonusCount;
//             YandexGame.savesData.day_of_week =   _dailyReward.day_of_week;
//             YandexGame.savesData.lastReciveBonus =   _dailyReward._lastReciveBonus;

            
//             YandexGame.savesData.isSaveMusic =   _musicOff.isSave;
//             YandexGame.savesData.isSaveMusicOne =   _musicOff.isSaveOne;

            
//             YandexGame.savesData.HighScore =   _score.HightScore;
//             YandexGame.savesData.ScoreCount =  _score.ScoreCount;

//             YandexGame.SaveProgress();
//         }
}
