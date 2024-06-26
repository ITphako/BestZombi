
using UnityEngine;
using TMPro;

public class TestGame : MonoBehaviour, IInjectServices, ITestGame
{
        [SerializeField] private int _number;

  private IGameEventsExecuter _gameEventsExecuter;
  private IGameEventsListener _gameEventsListener;
    private ICurrencyVault _currencyVault;

    public void InjectServices(IServiceLocator serviceLocator)
        {
            _gameEventsExecuter = serviceLocator.GetService<IGameEventsExecuter>();
            _gameEventsListener = serviceLocator.GetService<IGameEventsListener>();
            _currencyVault = serviceLocator.GetService<ICurrencyVault>();
        }

        public void Start()
        {
            _currencyVault.ChangeCurrency(_number );
        }

        public void Button()
        {

        }
}
