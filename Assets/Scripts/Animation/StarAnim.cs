
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class StarAnim : MonoBehaviour, IStarAnim
{
  [SerializeField] private Image _star;
  [SerializeField] private Color[] _colors;
  [SerializeField] private float _time;
  
  private Sequence _sequence;

  public void StarAnimGo()
  {
    _sequence = DOTween.Sequence();
    _sequence.Append(_star.DOColor(_colors[0], _time));
    _sequence.Append(_star.DOColor(_colors[1], _time));
    _sequence.Append(_star.DOColor(_colors[2], _time));
    _sequence.Append(_star.DOColor(_colors[3], _time));
    _sequence.Append(_star.DOColor(_colors[4], _time));
    _sequence.Append(_star.DOColor(_colors[5], _time));
    _sequence.Append(_star.DOColor(_colors[6], _time));
    _sequence.Append(_star.DOColor(_colors[7], _time));
    _sequence.SetLoops(-1);
  }

  public void StopAnim()
  {
    _sequence.Kill();
    _star.DOColor(_colors[8], 0.1f);
  }
}
