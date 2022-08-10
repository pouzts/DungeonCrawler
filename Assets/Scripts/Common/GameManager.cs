using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public enum eState
    { 
        Title,
        Lobby,
        GameStart,
        LevelStart,
        Level,
        LevelEnd,
        GameEnd,
        PlayerDead,
        GameOver,
        Win
    }

    private delegate void GameEvent();
    private event GameEvent gameEvent;

    private eState gameState = eState.Title;
    public eState GetEState
    {
        get { return gameState; }
        set 
        { 
            gameState = value;
            switch (gameState)
            {
                case eState.Title:
                    gameEvent = Title;
                    break;
                case eState.Lobby:
                    gameEvent = Lobby;
                    break;
                case eState.GameStart:
                    gameEvent = GameStart;
                    break;
                case eState.LevelStart:
                    gameEvent = LevelStart;
                    break;
                case eState.Level:
                    gameEvent = Level;
                    break;
                case eState.LevelEnd:
                    break;
                case eState.GameEnd:
                    break;
                case eState.PlayerDead:
                    break;
                case eState.GameOver:
                    break;
                case eState.Win:
                    break;
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        gameEvent?.Invoke();
    }

    private void Title()
    { 
        
    }

    private void Lobby()
    { 
    
    }

    private void GameStart()
    { 
        
    }

    private void LevelStart()
    { 
    
    }

    private void Level()
    {
        
    }
}
