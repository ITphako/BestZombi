
using UnityEngine;

namespace DG.Tweening
{

public class AnimRotationZombie : AnimBasicZombi
{
  [SerializeField] private float _angleStartRb;
  [SerializeField] private float _angleEndRb;
  [SerializeField] private float _timeRb;
  [SerializeField] private Vector2 _vectorUpLeg;
  [SerializeField] private Vector2 _vectorDownLeg;
  [SerializeField] private bool _isLeg;

    
    public void HitAnim(Rigidbody2D rigidbody2D)
{ 
    HitSizeAnim();
    HitColor();

    _sequence = DOTween.Sequence();
     _sequence.Append(rigidbody2D.DORotate(_angleStartRb, 0).SetEase(Ease.Linear));
     _sequence.Append(rigidbody2D.DORotate(_angleEndRb, _timeRb).SetEase(Ease.Linear));
     _sequence.Append(rigidbody2D.DORotate(_angleStartRb, _timeRb).SetEase(Ease.Linear));
     
     if(_isLeg == true)
     {
       HitAnimLegMove();
     }
}

public void HitAnimLegMove()
{
    _sequence = DOTween.Sequence();
     _sequence.Append(_partZombie.DOAnchorPos(_vectorUpLeg, 0, false).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOAnchorPos(_vectorDownLeg, _time, false).SetEase(Ease.Linear));
     _sequence.Append(_partZombie.DOAnchorPos(_vectorUpLeg, _time, false).SetEase(Ease.Linear));
}

} 

}
