using System;
using UnityEngine;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public UnityAction OnGameWin;
    public UnityAction OnGameOver;
    
    private void Awake()
    {
        Instance = this;
    }
}