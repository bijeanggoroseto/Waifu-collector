using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private float moveDirection;
    private Rigidbody2D rb;
    private SpriteRenderer playerSprite;
    private float jumpForce, moveSpeed;
    public PlayerData[] charaData;
    [SerializeField] private InputManager input;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        playerSprite.sprite = charaData[0].inGameSprite;
        moveSpeed = charaData[0].moveSpeed;
        jumpForce = charaData[0].jumpForce;
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
        playerSprite.sprite = charaData[index].inGameSprite;
        moveSpeed = charaData[index].moveSpeed;
        jumpForce = charaData[index].jumpForce;
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
