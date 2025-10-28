using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float drag = 0.3f;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D _rb;
    private Vector2 _moveInput;
    private Vector2 _velocity;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearDamping = drag;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move input: {_moveInput}");
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = _moveInput * speed;
    }
}
