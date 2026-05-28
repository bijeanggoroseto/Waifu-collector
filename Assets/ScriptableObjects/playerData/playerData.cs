using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public Sprite playerPortrait, weaponPortrait;
    public string playerName, weaponName;

}
