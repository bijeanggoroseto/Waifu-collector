using UnityEngine;
using UnityEngine.InputSystem;

public class AttackPoint : MonoBehaviour
{
    [SerializeField] private Camera maincam;
    private Vector3 mousePos;
    [SerializeField] private PlayerData[] charaData;
    [SerializeField] private InputManager input;
    private int charaIndex = 0;
    private Player player;
    private void Start()
    {
        player = GetComponentInParent<Player>();
        charaData = GetComponentInParent<Player>().charaData;
        input.indexChange += changeForm;
        input.isAttacking += attack;
    }

    private void changeForm(int index)
    {
        charaIndex = index;
    }

    private void attack(bool shouldAttack)
    {
        if (shouldAttack)
        {
            charaData[charaIndex].AttackBehaviour(this, shouldAttack);
        }
        else
        {
            charaData[charaIndex].AttackBehaviour(this, shouldAttack);
        }
    }

    private void Update()
    {
        mousePos = maincam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
