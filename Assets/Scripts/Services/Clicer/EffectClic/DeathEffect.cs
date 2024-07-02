
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
  [SerializeField] private GameObject _effectDeath;
  [SerializeField] private GameObject _effectDeathLight;

        [SerializeField] private Transform _spawn;

  public void DeathMobEffect()
  {
     Instantiate(_effectDeath, _spawn.position, Quaternion.identity);
     Instantiate(_effectDeathLight, _spawn.position, Quaternion.identity);
  }

}
