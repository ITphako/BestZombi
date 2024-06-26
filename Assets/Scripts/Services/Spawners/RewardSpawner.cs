
using UnityEngine;
// using YG;

public class RewardSpawner : ActorSpawnerBase
{
    [SerializeField] private float _nextSpawn = 0.0f;
     [SerializeField] private float _spawnDelay;
      [SerializeField] private Vector3 _whereSpawn;
      [SerializeField] private Rewards _reward;
    [SerializeField] private Rewards _empty;
    [SerializeField] private PigDeath _death;
      
      [SerializeField] private Transform _parent;
     private float _randomX;
     private bool _isReady;

   private IGameFactory _gameFactory;

    public void InjectServices(IServiceLocator serviceLocator)
        {
            _gameFactory = serviceLocator.GetService<IGameFactory>();
        }

//          private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

// private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

void Rewarded(int id)
{
    if (id == 2)
        ButtonReward();
}

      private void Update()
      {
        if(Time.time > _nextSpawn)
        {
           _nextSpawn = Time.time + _spawnDelay;
           if(_isReady == true)
           {
           _randomX = Random.Range(7,-6);
           _whereSpawn = new Vector3(_randomX, transform.position.y, transform.position.z);
           _empty = Instantiate(_reward, _whereSpawn, Quaternion.identity,_parent);
       _empty.DeathReward = _death;
           }
           _isReady = true;
        }
      }

        public void ButtonReward()
        {
           _empty.DeathReward.Reward();
              Destroy(_empty.gameObject);
        }

}
