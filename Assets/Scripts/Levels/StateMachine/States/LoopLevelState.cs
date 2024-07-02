
    public class LoopLevelState : ILevelState
    {
        private readonly LevelStateMachine _stateMachine;
        private readonly IGameEventsExecuter _gameEventsExecuter;

        public LoopLevelState(LevelStateMachine stateMachine, IServiceLocator serviceLocator)
        {
            _stateMachine = stateMachine;

            _gameEventsExecuter = serviceLocator.GetService<IGameEventsExecuter>();
        }

        public void Enter()
        {
            _gameEventsExecuter.OnLevelLoopEnter();
        }

        public void Exit()
        {
            
        }
    }