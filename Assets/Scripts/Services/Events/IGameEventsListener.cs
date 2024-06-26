
using System;

 public interface IGameEventsListener
    {
        event Action LevelLoaded;
        event Action LevelInitialized;
        event Action LevelLoopEnter;

        event Action LevelReady;
        event Action LevelEnd;

        event Action LevelBootstrap;
      
        event Action LevelWin;
        event Action LevelLose;
    }
