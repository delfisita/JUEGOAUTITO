using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la c�mara seguir�
    public Vector3 offset; // La distancia entre la c�mara y el objetivo

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
