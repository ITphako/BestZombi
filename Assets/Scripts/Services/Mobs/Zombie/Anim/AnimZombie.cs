
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace DG.Tweening
{

public class AnimZombie : MonoBehaviour
{
  [SerializeField] private RectTransform _head;
  [SerializeField] private Vector2 _vectorUp;
  [SerializeField] private Vector2 _vectorDown;
  [SerializeField] private float _time;
  [SerializeField] private float _angleStartRb;
  [SerializeField] private float _angleEndRb;
  [SerializeField] private float _timeRb;
   
  [SerializeField] private Image _partZombie;
  [SerializeField] private Color _colorStart;
  [SerializeField] private Color _colorEnd;
  [SerializeField] private float _timeColor;
  [SerializeField] private bool _isDontIdle;

  
  [SerializeField] private Vector2 _vectorUpLeg;
  [SerializeField] private Vector2 _vectorDownLeg;
  [SerializeField] private bool _isLeg;

    private Sequence _sequence;

public void HitAnim(Rigidbody2D rigidbody2D)
{ 
     HitSizeAnim();
     HitColor();

     if(_isLeg == true)
     {
       HitAnimLegMove();
     }

    _sequence = DOTween.Sequence();
     _sequence.Append(rigidbody2D.DORotate(_angleStartRb, 0).SetEase(Ease.Linear));
     _sequence.Append(rigidbody2D.DORotate(_angleEndRb, _timeRb).SetEase(Ease.Linear));
     _sequence.Append(rigidbody2D.DORotate(_angleStartRb, _timeRb).SetEase(Ease.Linear));
     
     
}

public void HitSizeAnim()
{
    _sequence = DOTween.Sequence();
     _sequence.Append(_head.DOSizeDelta(_vectorUp, 0, false).SetEase(Ease.Linear));
     _sequence.Append(_head.DOSizeDelta(_vectorDown, _time, false).SetEase(Ease.Linear));
     _sequence.Append(_head.DOSizeDelta(_vectorUp, _time, false).SetEase(Ease.Linear));
}

public void HitAnimLegMove()
{
    _sequence = DOTween.Sequence();
     _sequence.Append(_head.DOAnchorPos(_vectorUpLeg, 0, false).SetEase(Ease.Linear));
     _sequence.Append(_head.DOAnchorPos(_vectorDownLeg, _time, false).SetEase(Ease.Linear));
     _sequence.Append(_head.DOAnchorPos(_vectorUpLeg, _time, false).SetEase(Ease.Linear));
}

public void HitColor()
{
    _sequence = DOTween.Sequence();
     _sequence.Append(_partZombie.DOColor(_colorStart, 0).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOColor(_colorEnd, _timeColor).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOColor(_colorStart, _timeColor).SetEase(Ease.Linear));
}


    public void IdleAnim()
     {
    _sequence = DOTween.Sequence();
     _sequence.Append(_head.DOAnchorPos(_vectorUp, 0, false).SetEase(Ease.Linear));
     _sequence.Append(_head.DOAnchorPos(_vectorDown, _time, false).SetEase(Ease.Linear));
     _sequence.Append(_head.DOAnchorPos(_vectorUp, _time, false).SetEase(Ease.Linear));
    _sequence.SetLoops(-1);
     }

     private void Start()
     {
          if(_isDontIdle == false )
          {
        IdleAnim();
          }
     }

}
}