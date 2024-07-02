using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public abstract class ActorSpawnerBase : MonoBehaviour
{
    
        [SerializeField] protected Vector3 _spawnTransform;
        [SerializeField] protected GameObject _spawnActorsType;

     public virtual void StartSpawn()
        {

        }

        public virtual void StopSpawn()
        {

        }
}
