
using UnityEngine;

namespace DG.Tweening
{

public class Zombie : MonoBehaviour
{ 
  [SerializeField] private AnimZombie _animZombie;
  [SerializeField] private AnimRotationZombie _animRotationZombie;
  [SerializeField] private AnimSizeZombie _animSizeZombie;
  [SerializeField] private Rigidbody2D _rigidbody2D; 
  [SerializeField] private bool _isRotatePart; 


    public void OnMouseDown()
    {
        //_animZombie.HitAnim(_rigidbody2D);
       // _animZombie.HitSizeAnim();
       if(_isRotatePart == true)
       {
        _animRotationZombie.HitAnim(_rigidbody2D);
        _animRotationZombie.HitSizeAnim();
       }

       if(_isRotatePart == false)
       {
        _animSizeZombie.HitAnim(_rigidbody2D);
        _animSizeZombie.HitSizeAnim();
       }
    }
}

}