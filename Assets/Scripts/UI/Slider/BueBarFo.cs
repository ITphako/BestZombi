
using UnityEngine;
using System.Collections;

public class BueBarFo : Bar, IInjectServices
{ 
       [SerializeField] private double _maxValue;
       [SerializeField] private WeaponViewFo _weaponView;
        
    private ICurrencyVaultState _currencyVaultState;
    public StarAnim _starAnim;

    public bool _isGo = true;


     public void InjectServices(IServiceLocator serviceLocator)
        {
           _currencyVaultState  = serviceLocator.GetService<ICurrencyVaultState>();
        }

    private void Start()
    {
        StartCoroutine(GoBue());
        _currencyVaultState.OnChangedFo += OnValueChanged;
        Slider.value = 0;
        _currencyVaultState.MaxValueFo =_maxValue;
    }
       private void Update()
    { 
        _currencyVaultState.MaxValueFo = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueFo);
    }
    
    public void IsGo()
    {
       StartCoroutine(Go());
    }

    private IEnumerator Go()
    {
        yield return new WaitForSeconds(0.2f);
        _isGo = true;
    } 
    
    private IEnumerator GoBue()
    {
        while(true)
        {
        _currencyVaultState.MaxValueFo = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueFo);
        yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnDestroy()
    {
        _currencyVaultState.OnChangedTwo -= OnValueChanged;
    }
}
