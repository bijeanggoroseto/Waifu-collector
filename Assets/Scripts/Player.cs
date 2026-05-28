using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private float moveDirection;
    private Rigidbody2D rb;
    private SpriteRenderer playerSprite;
    [SerializeField] private float jumpForce, moveSpeed;
    [SerializeField] private Sprite[] charaSprite;
    [SerializeField] private InputManager input;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        input.indexChange += changeSprite;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }
    }

    public void changeSprite(int index)
    {
        playerSprite.sprite = charaSprite[index];
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<float>();
    }

    private void Update()
    {
        rb.linearVelocity = new Vector2(moveSpeed * moveDirection, rb.linearVelocity.y);
    }
}
