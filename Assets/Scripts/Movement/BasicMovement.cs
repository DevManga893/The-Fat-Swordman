using UnityEngine;

public class BasicMovement : IMovementStrategy
{
    public void Move(Transform transform, float speed)
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, v, 0f).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
