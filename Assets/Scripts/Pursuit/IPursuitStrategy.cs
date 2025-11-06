using UnityEngine;

public interface IPursuitStrategy
{
    void Pursue(Transform enemy, Transform target, float speed, float stopDistance);
}
