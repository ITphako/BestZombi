
using UnityEngine;

public class MainZombie : MonoBehaviour
{
        [SerializeField] private int _damage;
        [SerializeField] private ZombiLife _zombiLife;
        [SerializeField] private DeathEffect _deathEffect;
        [SerializeField] private MobInit _mobInit;

        public void OnChangeHealth()
        {
            _zombiLife.TakeDamage(_damage);
        }

        public void DeathMob()
        {
          _deathEffect.DeathMobEffect();
        }

        public void MobIniInFabrica()
        {
            _mobInit.FabricaReady();

        }

        public void HelthRespawn()
        {
            _zombiLife.RestartCoinEffect();
            _zombiLife.HealthZombi();
        }
}
