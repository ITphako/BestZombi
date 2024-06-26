
using UnityEngine;
using UnityEngine.UI;

public class CanvasChange : MonoBehaviour
{
  [SerializeField] private RectTransform _canvas;
  [SerializeField] private float _width;
  [SerializeField] private float _height;
  
[SerializeField] private  float _maxFuel ;
[SerializeField] private float _fuelTimeTw ;

[SerializeField] private float _testPresent ;
[SerializeField] private float _testPresentTwo ;
  [SerializeField] private bool _isOne;

[SerializeField] private float _percentage => (_width/_maxFuel) * 100;
[SerializeField] private float _numberFor => (_testPresent * _percentage) / 100 ;


[SerializeField] private float _spawnDelay ;
 private float _time ;
  
  private void Update()
  {
    _time +=Time.deltaTime;

               if(_time > _spawnDelay)
        {
            _time = 0;
   _isOne = true;
   _fuelTimeTw = _percentage;
   _width = _canvas.rect.width;
   _height = _canvas.rect.height;
        }

   if(_isOne == true)
   {
            _testPresentTwo = 0;
   _testPresentTwo +=_numberFor ;
   _isOne = false;
   }


  }
  }

