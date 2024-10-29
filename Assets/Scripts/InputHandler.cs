using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    
    private PlayerInputs playerInputs;
    private void Awake()
    {
        playerInputs = new PlayerInputs();
        playerInputs.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputs.Player.Move.ReadValue<Vector2>();
        inputVector.Normalize();
        return inputVector;
    }
}
