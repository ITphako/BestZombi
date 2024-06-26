
using UnityEngine;
using DG.Tweening;

public class Pig : MonoBehaviour
{
  [SerializeField] private float _time;
   [SerializeField] private AudioSource _music;
   [SerializeField] private AudioSource _deathMusic;
   [SerializeField] private int _health;
   [SerializeField] private GameObject _pig;
   [SerializeField] private Color _start;
   [SerializeField] private Color _end;
   [SerializeField] private  SpriteRenderer _render;

    private Sequence _sequence;
    private bool _isLife = true;
    private bool _isOpen = true;
    private bool _isGo = true;
    
   public  PigDeath DeathReward;
   
     public void OnMouseDown()
   {
    if(_health <= 0 &&_isOpen == true)
    {
      _isLife = false;
      _deathMusic.Play();
      FadeAnim();
      _isOpen =false;
    }
    if(_isLife == true)
    {
    _health--;
    HitAnim();
     _music.Play();
    }
   }
   
    public void FadeAnim()
    {
    _sequence = DOTween.Sequence();
     _sequence.Append(_render.DOFade(0f,0.5f).OnComplete(() => Death()));
    }

    public void HitAnim()
    {
    _sequence = DOTween.Sequence();
     _sequence.Append(_render.DOColor(_start, _time));
     _sequence.Append(_render.DOColor(_end, _time));
    }

    public void Death()
    {
      DeathReward.Reward();
      Destroy(_pig);
    }
}
