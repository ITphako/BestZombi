
using UnityEngine;

public class PigDeath : MonoBehaviour,IInjectServices
{
    
    private ICurrencyVault _currencyVault;
    private ICurrencyVaultState _currencyVaultState;
    public int numberOfReward;

     public void InjectServices(IServiceLocator serviceLocator)
        {
           _currencyVault  = serviceLocator.GetService<ICurrencyVault>();
           _currencyVaultState  = serviceLocator.GetService<ICurrencyVaultState>();
        }

        public void Reward()
        {
              _currencyVault.ChangeCurrency(_currencyVaultState.CurrentCountDouble / numberOfReward);
        }
}
