
using UnityEngine; 

public class EffectClic : MonoBehaviour
{
  [SerializeField] private GameObject _effectTap;
  [SerializeField] private GameObject _effectTapBlood;
        [SerializeField] private MainZombie _mainZombie;

  public void ZombieClick(GameObject effect)
  {
     _mainZombie.OnChangeHealth();
     ClickEffect( effect);
  }

  public void ZoneArea(GameObject effect)
  {
      ClickEffect( effect);
  }

  private void ClickEffect(GameObject effect)
  {
     Instantiate(effect, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
  }
 }
