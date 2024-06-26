
using UnityEngine;
using System.Collections; 

public class BueBar : Bar, IInjectServices
{ 
       [SerializeField] private double _maxValue;
       [SerializeField] private WeaponViewTwo _weaponView;
        
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
        _currencyVaultState.OnChangedTwo += OnValueChanged;
        Slider.value = 0;
        _currencyVaultState.MaxValueTwo =_maxValue;
    } 
     private void Update()
    {
        _currencyVaultState.MaxValueTwo = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueTwo);
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
        _currencyVaultState.MaxValueTwo = _weaponView.GetWeaponPrice();
        OnValueChanged(_currencyVaultState.CurrentCountDouble,_currencyVaultState.MaxValueTwo);
        yield return new WaitForSeconds(0.01f);
        }
    }

    private void OnDestroy()
    {
        _currencyVaultState.OnChangedTwo -= OnValueChanged;
    }
}
