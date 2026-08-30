<<<<<<< Updated upstream
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

=======
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 Input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
>>>>>>> Stashed changes
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
<<<<<<< Updated upstream
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
=======

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = Input * speed;
>>>>>>> Stashed changes
    }

    public void Move(InputAction.CallbackContext context)
    {
<<<<<<< Updated upstream
        moveInput = context.ReadValue<Vector2>();
    }
    
}


=======
        Input = context.ReadValue<Vector2>();
    }
}
>>>>>>> Stashed changes
