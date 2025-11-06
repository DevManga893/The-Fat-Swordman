using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target; // Transform do jogador
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f); // Posição relativa da câmera
    [SerializeField] private float smoothSpeed = 5f; // Velocidade de suavização

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
