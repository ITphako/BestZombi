
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Ads : MonoBehaviour
{
  [SerializeField] private Image _star;
  [SerializeField] private Color[] _colors;
  [SerializeField] private float _time;
  
  private Sequence _sequence;

  private void Start()
  {
    _sequence = DOTween.Sequence();
    _sequence.Append(_star.DOColor(_colors[0], _time));
    _sequence.Append(_star.DOColor(_colors[1], _time));
    _sequence.Append(_star.DOColor(_colors[2], _time));
    _sequence.Append(_star.DOColor(_colors[3], _time));
    _sequence.Append(_star.DOColor(_colors[4], _time));
    _sequence.SetLoops(-1);
  }
}
