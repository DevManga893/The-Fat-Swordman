using UnityEngine;

public class ProximityDamage : IDamageDealer
{
    private float damageInterval = 0.5f;
    private float damageAmount = 10f;
    private float stopDistance = 1.5f;
    private float lastDamageTime = 0f;

    public ProximityDamage(float stopDistance)
    {
        this.stopDistance = stopDistance;
    }

    public void TryDealDamage(Transform enemy, LifeBarController playerLife)
    {
        float distance = Vector3.Distance(enemy.position, playerLife.transform.position);

        if (distance <= stopDistance && Time.time >= lastDamageTime + damageInterval)
        {
            playerLife.ModifyValue(-damageAmount);
            lastDamageTime = Time.time;
        }
    }
}
