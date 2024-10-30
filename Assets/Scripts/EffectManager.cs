using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public ParticleSystem WinEffect;
    public ParticleSystem LoseEffect;
    private void Awake()
    {
        GameManager.OnGameWin += PlayWinEffect;
        GameManager.OnGameOver += PlayLoseEffect;
    }
    
    private void PlayWinEffect()
    {
        Debug.LogWarning("Play Win Effect");
        WinEffect.Play();
    }
    
    private void PlayLoseEffect()
    {
        Debug.LogWarning("Play Lose Effect");
        LoseEffect.Play();
    }
}