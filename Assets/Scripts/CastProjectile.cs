using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CastProjectile : MonoBehaviour
{
    private InputManager input;
    private Vector3 mousePos;
    private Camera mainCam;
    public float moveSpeed;

    private void Awake()
    {
        mainCam = FindAnyObjectByType<Camera>();
        input = FindAnyObjectByType<InputManager>();
    }
    private void Start()
    {
        input.isAttacking += Attacking;
    }

    void Attacking(bool shouldAttack)
    {
        if (!shouldAttack)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        mousePos = mainCam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePos = new Vector3(mousePos.x, mousePos.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, mousePos, moveSpeed);
    }

    private void OnDisable()
    {
        input.isAttacking -= Attacking;
    }
}
