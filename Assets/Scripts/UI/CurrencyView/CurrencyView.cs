
using TMPro;
using UnityEngine;

public class CurrencyView : MonoBehaviour, IInjectServices, ICurrencyView
{
        [SerializeField] private TMP_Text _currencyText;

        private ICurrencyVaultState _currencyVaultState;

         public void InjectServices(IServiceLocator serviceLocator)
        {
           _currencyVaultState  = serviceLocator.GetService<ICurrencyVaultState>();
           
            _currencyVaultState.OnChange += OnChangeCurrency;

            OnChangeCurrency(_currencyVaultState.CurrentCountDouble);
        }

        public void OnChangeCurrency(double currentCount )
        {
            _currencyText.text = ShortScaleString.parseDouble(currentCount, 1, 100000, true).ToString();
        }
    }
