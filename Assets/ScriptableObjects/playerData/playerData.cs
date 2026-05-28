using UnityEngine;

public abstract class PlayerData : ScriptableObject
{
    public Sprite playerPortrait, weaponPortrait, inGameSprite;
    public string playerName, weaponName;
    public float moveSpeed, jumpForce, spawnOffset, cooldown;
    public GameObject projectile;
    public abstract void AttackBehaviour(AttackPoint attackpoint, bool shouldAttack);
}
