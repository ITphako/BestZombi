
using UnityEngine;

public class Bonus : MonoBehaviour
{
       public int _bonusCount;
       public ChestAnim _anim;

       [SerializeField] private DailyReward _day;

        public void GetReward(int number)
            {
                if(_bonusCount == number)
                {
                     if( _day.day_of_week == _day._lastReciveBonus)
               {
                if(_day.isRewardGet == false)
                {
                   _day.Init(number);
                    _anim.isStart = false;
                }
               }
               
               _day.isRewardGet = true;
                }
             
            }
}