using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fusion;
using Fusion.Sockets;
using System;

public class GameManager : Singleton<GameManager>
{
    //[SerializeField] ScreenFade screenFade;
    //[SerializeField] SceneLoader sceneLoader;

    public enum eState
    { 
        Title,
        Lobby,
        GameStart,
        LevelStart,
        Game,
        LevelEnd,
        PlayerDead,
        GameOver,
        Win
    }

    private bool isGameOver = false;
    private bool isGameStart = false;

    private float timer = 0f;

    private eState gameState = eState.Title;
    public eState GameState 
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
                    timer = 5f;
                    gameEvent = Lobby;
                    break;
                case eState.GameStart:
                    timer = 5f;
                    gameEvent = GameStart;
                    break;
                case eState.LevelStart:
                    timer = 5f;
                    gameEvent = LevelStart;
                    break;
                case eState.Game:
                    timer = 5f;
                    gameEvent = Game;
                    break;
                case eState.LevelEnd:
                    timer = 5f;
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
        }
    }

    private delegate void GameEvent();
    private event GameEvent gameEvent;

    void Start()
    {
        GameState = eState.Game;

        //SceneManager.activeSceneChanged += OnSceneWasLoaded;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
            gameEvent?.Invoke();

        print(gameState);
    }

    private void Title()
    {
        
    }

    private void Lobby()
    {
        if (isGameStart)
            GameState = eState.GameStart;
    }

    private void GameStart()
    {
        isGameOver = false;
        GameState = eState.LevelStart;
    }

    private void LevelStart()
    { 
    
    }

    private void Game()
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
