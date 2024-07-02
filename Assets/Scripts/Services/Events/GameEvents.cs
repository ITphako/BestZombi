using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

  public class GameEvents :  IGameEventsListener, IGameEventsExecuter
    {
          public event Action LevelBootstrap;

        public event Action LevelLoaded;
        public event Action LevelInitialized;
        public event Action LevelLoopEnter;
        public event Action LevelEnd;

        public event Action LevelWin;
        public event Action LevelLose;

        public event Action LevelReady;

         public void OnLevelBootstrap() =>  LevelBootstrap?.Invoke();
        
        
        public void OnLevelLoaded() => LevelLoaded?.Invoke(); 
        
         public void OnLevelInitialized() =>  LevelInitialized?.Invoke();

         public void OnLevelLoopEnter() =>   LevelLoopEnter?.Invoke();

         public void OnLevelReady() => LevelReady?.Invoke();

        public void OnLevelEnd() => LevelEnd?.Invoke();

        public void OnLevelWin() => LevelWin?.Invoke();

        public void OnLevelLose() => LevelLose?.Invoke();
    }