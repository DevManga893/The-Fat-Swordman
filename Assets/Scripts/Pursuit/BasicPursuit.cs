using UnityEngine;

public class BasicPursuit : IPursuitStrategy
{
    public void Pursue(Transform enemy, Transform target, float speed, float stopDistance)
    {
        Vector3 direction = target.position - enemy.position;
        float distance = direction.magnitude;

        if (distance > stopDistance)
        {
            Vector3 moveDirection = direction.normalized;
            enemy.position += moveDirection * speed * Time.deltaTime;
        }
    }
}
