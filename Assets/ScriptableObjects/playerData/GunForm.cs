using UnityEngine;

[CreateAssetMenu(fileName = "GunForm", menuName = "ScriptableObjects/GunForm")]
public class GunForm : PlayerData
{
    public override void AttackBehaviour(AttackPoint attackpoint, bool shouldAttack)
    {
        if (shouldAttack)
        {
            Instantiate(projectile, attackpoint.transform.position, attackpoint.transform.rotation);
        }
    }
}
