using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public enum GameStates
    { 
        Title,
        Lobby,
        StartGame,
        Level,
        EndGame,
        Dead,
        GameOver,
        Win
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
