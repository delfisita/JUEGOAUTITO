using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la cámara seguirá
    public Vector3 offset; // La distancia entre la cámara y el objetivo

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
