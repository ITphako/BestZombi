using UnityEngine;
using System.Collections;

public class BueBarThree : Bar, IInjectServices
{ 
       [SerializeField] private double _maxValue;
       [SerializeField] private WeaponViewThree _weaponView;
        
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
        _currencyVaultState.OnChangedThree += OnValueChanged;
        Slider.value = 0;
        _currencyVaultState.MaxValueThree =_maxValue;
    } 
    
    private void Update()
    {
        _currencyVaultState.MaxValueThree = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueThree);
    }
    public void IsGo()
    {
       StartCoroutine(Go());
    }

    private IEnumerator Go()
    {
        yield return new WaitForSeconds(0.1f);
        _isGo = true;
    } 
    
    private IEnumerator GoBue()
    {
        while(true)
        {
        _currencyVaultState.MaxValueThree = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueThree);
        yield return new WaitForSeconds(0.01f);
        }
    }

    private void OnDestroy()
    {
        _currencyVaultState.OnChangedThree -= OnValueChanged;
    }
}
