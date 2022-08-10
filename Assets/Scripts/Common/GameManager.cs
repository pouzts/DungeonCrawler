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
        PlayerDead,
        GameOver,
        Win
    }

    public eState GameState { get; set; }

    private delegate void GameEvent();
    private event GameEvent gameEvent;
    
    private float timer = 0f;

    void Start()
    {
        GameState = eState.Title;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        switch (GameState)
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
                gameEvent = LevelEnd;
                break;
            case eState.PlayerDead:
                gameEvent = PlayerDead;
                break;
            case eState.GameOver:
                gameEvent = GameOver;
                break;
            case eState.Win:
                gameEvent = Win;
                break;
        }

        if (timer <= 0)
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

    private void LevelEnd()
    { 
    
    }

    private void PlayerDead()
    { 
    
    }

    private void GameOver()
    { 
    
    }

    private void Win()
    { 
    
    }
}
