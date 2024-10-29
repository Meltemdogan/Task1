using System;
using TMPro;
using UnityEngine;


namespace DefaultNamespace
{
    public class Timer : MonoBehaviour
    {
        public static Timer Instance { get; private set; }
        public TMP_Text TimerText;
        public float StartTime;
        public float TimeLeft;
        
        private void Awake()
        {
            Instance = this;
            m_IsActive = true;
            GameManager.OnGameWin += OnGameWin;
        }
        
        private void OnGameWin()
        {
            m_IsActive = false;
        }
        
        private void Start()
        {
            TimeLeft = StartTime;
        }
        
        private void Update()
        {
            CountDown();
        }
        
        private bool m_IsActive;
        
        private void CountDown()
        {
            if (m_IsActive == true)
            {
                TimeLeft -= Time.deltaTime;
                TimerText.text = TimeLeft.ToString("F1");
                if (TimeLeft <= 0)
                {
                    TimerText.text = "Time's up!";
                    GameManager.OnGameOver?.Invoke();
                    m_IsActive = false;
                }
            }
        }
    }
}