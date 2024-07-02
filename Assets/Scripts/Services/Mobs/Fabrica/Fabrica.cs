using System;
using UnityEngine;

public class Fabrica : MonoBehaviour
{

  [SerializeField] private float _spawnDelay;
   [SerializeField] private float _time;
   public bool IsReady;
   public Action Init;
    
   
        private void Update()
        {
            if(IsReady == true)
            {
                _time +=Time.deltaTime;
            }

               if(_time > _spawnDelay)
        {
            _time = 0;
             Init?.Invoke();
           IsReady = false;
        }
        }

        public void InstMobs(GameObject mob)
        {
           mob.SetActive(true);
        }
}
