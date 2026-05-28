using UnityEngine;

public class AttackPoint : MonoBehaviour
{
    [SerializeField] private PlayerData[] currentForm;
    [SerializeField] private InputManager input;
    private void Start()
    {
        Player player = GetComponentInParent<Player>();
        input.indexChange += changeForm;
    }

    private void changeForm(int index)
    {
        Debug.Log(index);
    }
}
