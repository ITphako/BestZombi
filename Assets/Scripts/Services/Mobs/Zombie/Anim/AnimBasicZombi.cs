
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace DG.Tweening
{

public abstract class  AnimBasicZombi : MonoBehaviour 
{
  [SerializeField] protected RectTransform _partZombie;
  [SerializeField] protected Vector2 _vectorUp;
  [SerializeField] protected Vector2 _vectorDown;
  [SerializeField] protected float _time;
  [SerializeField] private Image _imageColor;
  [SerializeField] private Color _colorStart;
  [SerializeField] private Color _colorEnd;
  [SerializeField] private float _timeColor;
  [SerializeField] protected Vector2 _vectorUpIdle;
  [SerializeField] protected Vector2 _vectorDownIdle;
  [SerializeField] protected float _timeIdle;

    protected Sequence _sequence;
  
    protected void IdleAnim()
     {
    _sequence = DOTween.Sequence();
     _sequence.Append(_partZombie.DOAnchorPos(_vectorUpIdle, 0, false).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOAnchorPos(_vectorDownIdle, _timeIdle, false).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOAnchorPos(_vectorUpIdle, _timeIdle, false).SetEase(Ease.Linear));
    _sequence.SetLoops(-1);
     }

     public void HitSizeAnim()
{
    _sequence = DOTween.Sequence();
     _sequence.Append(_partZombie.DOSizeDelta(_vectorUp, 0, false).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOSizeDelta(_vectorDown, _time, false).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOSizeDelta(_vectorUp, _time, false).SetEase(Ease.Linear));
}

protected void HitColor()
{
    _sequence = DOTween.Sequence();
     _sequence.Append(_imageColor.DOColor(_colorStart, 0).SetEase(Ease.Linear));
     _sequence.Append(_imageColor.DOColor(_colorEnd, _timeColor).SetEase(Ease.Linear));
     _sequence.Append(_imageColor.DOColor(_colorStart, _timeColor).SetEase(Ease.Linear));
}

      private void Start()
     {
        IdleAnim();
     }

}

}