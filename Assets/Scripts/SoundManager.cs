using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public AudioSource WinSound;
    public AudioSource LoseSound;
    private void Awake()
    {
        GameManager.Instance.OnGameWin += PlayWinSound;
        GameManager.Instance.OnGameOver += PlayLoseSound;
    }
    
    private void PlayWinSound()
    {
        Debug.LogWarning("Play Win Sound");
        WinSound.Play();
    }
    
    private void PlayLoseSound()
    {
        Debug.LogWarning("Play Lose Sound");
        LoseSound.Play();
    }
}