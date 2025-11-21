/*using UnityEngine;

public class BasicMovement : IMovementStrategy
{
    public void Move(Transform transform, float speed)
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, v, 0f).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}*/

using UnityEngine;

public class BasicMovement : IMovementStrategy
{
    public void Move(Transform transform, float speed)
    {
        // Captura entrada do teclado (WASD ou setas)
        float h = Input.GetAxisRaw("Horizontal"); // -1 esquerda, +1 direita
        float v = Input.GetAxisRaw("Vertical");   // -1 baixo, +1 cima

        // Direção normalizada (permite diagonais)
        Vector3 direction = new Vector3(h, v, 0f).normalized;

        // Movimento do jogador
        if (direction.magnitude > 0f)
        {
            transform.position += direction * speed * Time.deltaTime;

            // Rotaciona o sprite para olhar na direção do movimento
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }
}

