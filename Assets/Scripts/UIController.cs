using System;
using UnityEngine;


namespace DefaultNamespace
{
    public class UIController : MonoBehaviour
    {
        public GameObject GameOverPanel;
        public GameObject GameWinPanel;
        private GameManager gameManager;
        
        private void Start()
        {
            GameManagerInitializer();
            EventInitializer();
        }
        
        private void GameManagerInitializer()
        {
            gameManager = GameManager.Instance;
        }
        private void EventInitializer()
        {
            gameManager.OnGameOver += OnGameOver;
            gameManager.OnGameWin += OnGameWin;
        }
        
        private void OnGameOver()
        {
            Debug.LogWarning("Game Over");
            GameOverPanel.SetActive(true);
        }
        
        private void OnGameWin()
        {
            GameWinPanel.SetActive(true);
        }
    }
}