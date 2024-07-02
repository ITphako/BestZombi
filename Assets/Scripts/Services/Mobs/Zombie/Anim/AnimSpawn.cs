
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class AnimSpawn : MonoBehaviour
{
  [SerializeField] private RectTransform _mobRect;
  [SerializeField] private Vector3 _size;
  [SerializeField] private Vector3 _sizeStart;
  [SerializeField] private float _timeSize;
  [SerializeField] private float _timeStart;
  [SerializeField] private PartZombie[] _partsZombie;
  [SerializeField] private Rigidbody2D _rbLegLeft;
  [SerializeField] private Rigidbody2D _rbLegRight;
  [SerializeField] private Rigidbody2D _rbHandRight;
  [SerializeField] private Rigidbody2D _rbHandLeft;
  
  private Sequence _sequence;
 
    public void RespawnMob()
    {  
       _sequence = DOTween.Sequence();
     _sequence.Append(_mobRect.DOSizeDelta(_size, _timeSize, false));
    }
    
    public void StartScale()
    {  
       _sequence = DOTween.Sequence();
     _sequence.Append(_mobRect.DOSizeDelta(_sizeStart, _timeStart, false));
     _sequence.Append(_rbLegLeft.DORotate(0, 0));
     _sequence.Append(_rbLegRight.DORotate(0, 0));
     _sequence.Append(_rbHandLeft.DORotate(0, 0));
     _sequence.Append(_rbHandRight.DORotate(0, 0));
    }
}
