
using UnityEngine;
using System.Collections;

public class BueBarSix : Bar, IInjectServices
{ 
       [SerializeField] private double _maxValue;
       [SerializeField] private WeaponViewSix _weaponView;
        
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
        _currencyVaultState.OnChangedSix += OnValueChanged;
        Slider.value = 0;
        _currencyVaultState.MaxValueSix =_maxValue;
    } 
        private void Update()
    { 
        _currencyVaultState.MaxValueSix = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueSix);
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
        _currencyVaultState.MaxValueSix = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueSix);
        yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnDestroy()
    {
        _currencyVaultState.OnChangedTwo -= OnValueChanged;
    }
}
