
using UnityEngine;
using UnityEngine.UI;
// using YG;

public class ADTimer : MonoBehaviour
{
    
    [SerializeField] private float _nextSpawn = 0.0f;
     [SerializeField] private float _spawnDelay;
     [SerializeField] private float _time;
     
     [SerializeField] private bool isPicked;
      [SerializeField] private GameObject _unLock;
      [SerializeField] private Button _button;

      
      [SerializeField] private RewardButton _reward;

      
      [SerializeField] private GameObject _camera;

//       private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

// private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

void Rewarded(int id)
{
    if (id == 1)
        ButtonReward();
}

   
        private void Update()
        {
                _time +=Time.deltaTime;

               if(_time > _spawnDelay)
        {
            _time = 0;
              _button.interactable = true;
              isPicked = false;
              _unLock.SetActive(false);
        }

        if(isPicked == true)
        {
              _unLock.SetActive(true);
        }
        else
        {

        }

        if( _reward.IsOpen == true)
        {
       _camera.SetActive(false);
        }
        }

        public void ButtonPicked()
        {
              isPicked = true;
              _button.interactable = false;
            _time = 0;
        }

        public void ButtonRewardYG()
        {
             // YandexGame.RewVideoShow(1);
        }

        public void ButtonReward()
        {
              _unLock.SetActive(false);
              isPicked = false;
              _button.interactable = true;
        }
            

}
