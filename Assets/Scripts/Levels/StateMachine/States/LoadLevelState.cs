
using UnityEngine;

    public class LoadLevelState : ILevelState
    {
        private readonly LevelStateMachine _stateMachine;
        private readonly IGameEventsExecuter _gameEventsExecuter;

        public LoadLevelState(LevelStateMachine stateMachine, IServiceLocator serviceLocator)
        {
            _stateMachine = stateMachine;

            _gameEventsExecuter = serviceLocator.GetService<IGameEventsExecuter>();
        }

        public void Enter()
        {
            _gameEventsExecuter.OnLevelLoaded();

            _stateMachine.EnterIn<InitializeLevelState>();
        }

      
        public void Exit()
        {
            
        }
    }