using UnityEngine;
using UnityEngine.InputSystem;

public class Sword : MonoBehaviour
{
    private InputManager input;
    private AttackPoint attackpoint;

    private void Awake()
    {
        input = FindAnyObjectByType<InputManager>();
        attackpoint = FindAnyObjectByType<AttackPoint>();
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
        transform.position = attackpoint.transform.position;
        transform.rotation = attackpoint.transform.rotation;
    }

    private void OnDisable()
    {
        input.isAttacking -= Attacking;
    }
}
