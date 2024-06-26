
using UnityEngine;

public class MobInit : MonoBehaviour
{
  [SerializeField] private Fabrica _fabrica;
  [SerializeField] private GameObject _mobs;
        [SerializeField] private MainZombie _mainZombie;
        [SerializeField] private AnimSpawn _animSpawn;
        [SerializeField] private ChangeImage _changeImage;

  private void OnEnable()
  {
    _fabrica.Init +=OnInit;
  }

  private void OnInit()
  {
    _animSpawn.StartScale();
    _fabrica.InstMobs(_mobs);
    _animSpawn.RespawnMob();
    _changeImage.RandomSkin();
  }

  public void FabricaReady()
  {
    _mainZombie.HelthRespawn();
    _fabrica.IsReady = true;
  }
}
