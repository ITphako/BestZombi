
using UnityEngine; 
 
public class ZombiLife : Bar
{
  [SerializeField] private GameObject _coin;
  [SerializeField] private MainZombie _mainZombie;
  [SerializeField] private GameObject _zombie;
  [SerializeField] private Lifebar _lifeBar;
  public int _health;
  public int _helthRespawn;

      public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            _mainZombie.MobIniInFabrica();
            _mainZombie.DeathMob();
            _coin.SetActive(true);
            _zombie.SetActive(false);
        }
    }

    public void HealthZombi()
    {
        _health = _helthRespawn;
        _lifeBar.hp = _health;
        _lifeBar.HelthGradientMax();
    }

    public void RestartCoinEffect()
    {
            _coin.SetActive(false);
    }
}
