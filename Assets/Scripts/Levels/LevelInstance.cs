
using UnityEngine;

    public class LevelInstance : MonoBehaviour
    {
        [SerializeField] private WeaponView _weaponView;
        [SerializeField] private CurrencyView _currencyView;
        [SerializeField] private Clicer _clicer;
        [SerializeField] private GameFactory _gameFactory;
        [SerializeField] private Shop _shop;
        [SerializeField] private StarAnim _starAnim;
        [SerializeField] private LevelUp _levelUp;
        [SerializeField] private AudioSource _music;
        [SerializeField] private EffectClic _effectClic;
        [SerializeField] private ZombiLife _zombiLife;

        private IServiceLocator _services;
        private IGameEventsListener _gameEventsListener;
        private IGameEventsExecuter _gameEventsExecuter;

        private LevelStateMachine _levelStateMachine;

        private void Awake()
        {
            CreateServices();
            InjectServicesInSceneObjects();

            CreateLevelStateMachine();

            _levelStateMachine.EnterIn<LoadLevelState>();
            
            _gameEventsExecuter.OnLevelBootstrap();
            _music.Play();
        }

        private void CreateServices()
        {
            _services = new ServiceLocator();

            GameEvents gameEvents = new GameEvents();
            _gameEventsListener = gameEvents;
            _gameEventsExecuter = gameEvents;

            CurrencyVault currencyVault = new CurrencyVault();

            _services.RegisterService<IGameEventsListener>(gameEvents);
            _services.RegisterService<IGameEventsExecuter>(gameEvents);
            _services.RegisterService<ICurrencyVault>(currencyVault);
            _services.RegisterService<ICurrencyVaultState>(currencyVault);
            _services.RegisterService<IWeaponView>(_weaponView);
            _services.RegisterService<ICurrencyView>(_currencyView);
            _services.RegisterService<IClicer>(_clicer);
            _services.RegisterService<IGameFactory>(_gameFactory);
            _services.RegisterService<IShopBue>(_shop);
            _services.RegisterService<IStarAnim>(_starAnim);
            _services.RegisterService<ILevelUp>(_levelUp);
        }

        private void InjectServicesInSceneObjects()
        {
            var dependencies = FindObjectsOfType<MonoBehaviour>();
            
            foreach (MonoBehaviour target in dependencies)
            {
                if (target.TryGetComponent<IInjectServices>(out var inject))
                    inject.InjectServices(_services);
            }
        }

        private void CreateLevelStateMachine()
        {
            _levelStateMachine = new LevelStateMachine();

            _levelStateMachine
                .AddLevelState(new LoadLevelState(_levelStateMachine, _services))
                .AddLevelState(new InitializeLevelState(_levelStateMachine, _services))
                .AddLevelState(new LoopLevelState(_levelStateMachine, _services));
        }
    }