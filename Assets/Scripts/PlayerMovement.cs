using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputHandler inputHandler;
    private Rigidbody rb;
    [SerializeField] private float moveSpeed = 5f;
    
    private bool isWalking;
    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        HandlePlayerMovement();
    }
    private void HandlePlayerMovement()
    {
        Vector2 inputVector = inputHandler.GetMovementVectorNormalized();
        
        Vector3 moveDirection = new Vector3(inputVector.x, 0, inputVector.y);
        transform.position += moveDirection * (moveSpeed * Time.deltaTime);
        
        isWalking = moveDirection != Vector3.zero;
        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);
    }
}  
