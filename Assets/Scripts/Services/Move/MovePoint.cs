
using UnityEngine;
using DG.Tweening;

public class MovePoint : MonoBehaviour
{
    [SerializeField] private GameObject[] _pointsArray;
     [SerializeField] private float _time;

    private Sequence _sequence;

    public void MoveAnim(Pig empty)
    {
        
    _sequence = DOTween.Sequence();
        _sequence.Append(empty.transform.DOMove(_pointsArray[1 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[2 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[3 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[4 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear).OnComplete(() => RotatePig(0.6f,empty) ));
        _sequence.Append(empty.transform.DOMove(_pointsArray[3 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[2 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[1 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[0 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear).OnComplete(() => RotatePig(-0.6f,empty) ));
    _sequence.SetLoops(-1).SetEase(DG.Tweening.Ease.Linear);
    }

    public void RotatePig(float rotate, Pig empty)
    {
        empty.transform.localScale = new Vector3(rotate, 0.6f, 1);
    }

     public void MoveAnimTwo(Pig empty)
    {
        
    _sequence = DOTween.Sequence();
        _sequence.Append(empty.transform.DOMove(_pointsArray[3 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[2 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[1 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[0 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear).OnComplete(() => RotatePig(-0.6f,empty) ));
        _sequence.Append(empty.transform.DOMove(_pointsArray[1 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[2 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[3 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear));
        _sequence.Append(empty.transform.DOMove(_pointsArray[4 ].transform.position,_time).SetEase(DG.Tweening.Ease.Linear).OnComplete(() => RotatePig(0.6f,empty) ));
    _sequence.SetLoops(-1).SetEase(DG.Tweening.Ease.Linear);
    }
}
