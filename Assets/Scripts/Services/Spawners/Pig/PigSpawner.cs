
using UnityEngine;   

public class PigSpawner : MonoBehaviour
{
   [SerializeField] private AudioSource _music;
    [SerializeField] private Pig _pig;
    [SerializeField] private Pig _pigTwo;
    [SerializeField] private GameObject _smoke;
    [SerializeField] private Transform _spawn;
    [SerializeField] private Transform _spawnTwo;
    [SerializeField] private MovePoint _points;
    [SerializeField] private PigDeath _death;
    [SerializeField] private float _nextSpawn = 0.0f;
     [SerializeField] private float _spawnDelay;

    [SerializeField] private Pig _empty;
      [SerializeField] private Transform _parent;
      [SerializeField] private GameObject _camera;

    private bool _isReady = false;

    public void CreatePig()
    {
        _music.Play();
        Instantiate(_smoke, _spawn.position , Quaternion.identity);
       _empty =  Instantiate(_pig, _spawn.position , Quaternion.identity);
       _points.MoveAnim(_empty);
       _empty.DeathReward = _death;
       _camera.SetActive(true);
    }

    public void CreatePigTime()
    {
        _music.Play();
        Instantiate(_smoke, _spawnTwo.position , Quaternion.identity);
       _empty =  Instantiate(_pigTwo, _spawnTwo.position , Quaternion.identity, _parent);
       _points.MoveAnimTwo(_empty);
       _empty.DeathReward = _death;
    }

    private void Update()
    {
         if(Time.time > _nextSpawn)
         {
           _nextSpawn = Time.time + _spawnDelay;
           
           if(_isReady == true)
           CreatePigTime();
           
       _camera.SetActive(true);

           _isReady = true;
         }
    }
}
