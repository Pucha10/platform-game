using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float smoothness = 0.5f;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        Vector3 targetPosition = player.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness * Time.deltaTime);
    }
}
