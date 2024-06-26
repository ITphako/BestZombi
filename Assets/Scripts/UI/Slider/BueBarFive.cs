
using UnityEngine;
using System.Collections;

public class BueBarFive : Bar, IInjectServices
{ 
       [SerializeField] private double _maxValue;
       [SerializeField] private WeaponViewFive _weaponView;
        
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
        _currencyVaultState.OnChangedFive += OnValueChanged;
        Slider.value = 0;
        _currencyVaultState.MaxValueFive =_maxValue;
    }
     private void Update()
    { 
        _currencyVaultState.MaxValueFive = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueFive);
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
        _currencyVaultState.MaxValueFive = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueFive);
        yield return new WaitForSeconds(0.01f);
        }
    }

    private void OnDestroy()
    {
        _currencyVaultState.OnChangedTwo -= OnValueChanged;
    }
}
