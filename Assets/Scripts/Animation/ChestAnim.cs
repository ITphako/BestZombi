
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChestAnim : MonoBehaviour
{
  [SerializeField] private float _time;
    public Transform chest;
    public bool isStart = true;
    public bool snapping = true;
    public Vector3[] points;

    private Sequence _sequence;

    private void Update()
    {
        if(isStart == true)
        {
      StarAnimGo();
      isStart = false;
        }
    }

  public void StarAnimGo()
  {
    _sequence = DOTween.Sequence();
    _sequence.Append(chest.DOScale(points[1], _time));
    _sequence.Append(chest.DOScale(points[2], _time));
    _sequence.Append(chest.DOScale(points[3], _time));
    _sequence.Append(chest.DOScale(points[2], _time));
    _sequence.Append(chest.DOScale(points[1], _time));
    _sequence.Append(chest.DOScale(points[0], _time));
    _sequence.SetLoops(-1);
  }
}
