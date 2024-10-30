using System;
using DefaultNamespace;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            GameManager.Instance.OnGameWin?.Invoke();
        }
    }
}