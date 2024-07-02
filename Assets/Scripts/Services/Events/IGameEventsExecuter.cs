
using System;

  public interface IGameEventsExecuter
    {
        void OnLevelBootstrap();
        void OnLevelEnd();
        void OnLevelInitialized();
        void OnLevelLoaded();
        void OnLevelLoopEnter();
        void OnLevelLose();
        void OnLevelReady();
        void OnLevelWin();
    }