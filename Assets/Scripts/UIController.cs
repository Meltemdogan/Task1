using System;
using UnityEngine;


namespace DefaultNamespace
{
    public class UIController : MonoBehaviour
    {
        public GameObject GameOverPanel;
        public GameObject GameWinPanel;
        
        private void Awake()
        {
            GameManager.OnGameOver += OnGameOver;
            GameManager.OnGameWin += OnGameWin;
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