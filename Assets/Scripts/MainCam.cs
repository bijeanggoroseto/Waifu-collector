using UnityEngine;

public class MainCam : MonoBehaviour
{
    public float offsetY;
    [SerializeField] private Transform player;
    [SerializeField] private float smoothSpeed;

    private void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y + offsetY, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}
