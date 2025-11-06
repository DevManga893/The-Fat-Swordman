using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float pursuitSpeed = 5f;
    [SerializeField] private float stopDistance = 1.5f;

    private IPursuitStrategy pursuitStrategy;
    private IDamageDealer damageDealer;
    private LifeBarController playerLife;

    private void Start()
    {
        pursuitStrategy = new BasicPursuit();
        damageDealer = new ProximityDamage(stopDistance);
        playerLife = target.GetComponent<LifeBarController>();
    }

    private void Update()
    {
        if (target != null)
        {
            pursuitStrategy.Pursue(transform, target, pursuitSpeed, stopDistance);
            damageDealer.TryDealDamage(transform, playerLife);
        }
    }
}
