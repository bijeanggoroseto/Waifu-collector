using UnityEngine;

public class AttackHitbox : MonoBehaviour
{
    [SerializeField] private float timer;

    private void Start()
    {
        Destroy(gameObject, timer);
    }
}
