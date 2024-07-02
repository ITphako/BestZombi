
    public class InitializeLevelState : ILevelState
    {
        private readonly LevelStateMachine _stateMachine;
        private readonly IGameEventsExecuter _gameEventsExecuter;

        public InitializeLevelState(LevelStateMachine stateMachine, IServiceLocator serviceLocator)
        {
            _stateMachine = stateMachine;

            _gameEventsExecuter = serviceLocator.GetService<IGameEventsExecuter>();

        }

        public void Enter()
        {
            _gameEventsExecuter.OnLevelInitialized();

            _stateMachine.EnterIn<LoopLevelState>();
        }

        public void Exit()
        {
            
        }
    }