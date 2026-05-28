using System;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    private float startPos, length;
    [SerializeField] private GameObject mainCam;
    public float parallaxEffect;

    private void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float distance = mainCam.transform.position.x * parallaxEffect;
        float movement = mainCam.transform.position.x * (1 - parallaxEffect);
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
        if(movement > startPos + length)
        {
            startPos += length;
        }
        if (movement < startPos - length)
        {
            startPos -= length;
        }
    }
}
