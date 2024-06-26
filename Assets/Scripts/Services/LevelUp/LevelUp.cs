
using UnityEngine;

public class LevelUp : MonoBehaviour, ILevelUp
{
  [SerializeField] private int _upCount;

  public void LevelBue()
  {
    _upCount++;
  }

  public int GetCount()
  {
    return _upCount;
  }
}
