
using UnityEngine;
using System.Collections;

public class StarBar : Bar,IInjectServices
{
        [SerializeField] private int _maxValue;
        [SerializeField] private double _maxValueDobule;
        
    private ICurrencyVaultState _currencyVaultState;
    private IWeaponView _weaponView;
    public StarAnim _starAnim;

    public bool _isGo = true;
    public bool _isGoWin = true;

     public void InjectServices(IServiceLocator serviceLocator)
        {
           _currencyVaultState  = serviceLocator.GetService<ICurrencyVaultState>();
            _weaponView = serviceLocator.GetService<IWeaponView>();
        }

    private void Start()
    {
        _currencyVaultState.OnChanged += OnValueChanged;
        Slider.value = 0;
        _currencyVaultState.MaxValueDouble =_maxValueDobule;
    } 
    
    private void Update()
    {
        if(Slider.value == 1 && _isGo == true)
        {
            if(_isGoWin == true)
            {
            _isGo = false;
          _starAnim.StarAnimGo();
            }
        }
        
        _currencyVaultState.MaxValueDouble = _weaponView.GetWeaponPriceDouble();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueDouble);
    }

    public void IsGo()
    {
       StartCoroutine(Go());
    }

    private IEnumerator Go()
    {
        yield return new WaitForSeconds(1f);
        _isGo = true;
    }

    private void OnDestroy()
    {
        _currencyVaultState.OnChanged -= OnValueChanged;
    }
}