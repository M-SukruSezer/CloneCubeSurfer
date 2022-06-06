using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameState _gameState;

    public enum GameState
    {
        Play,
        Finish,
        Failed
    }
}
