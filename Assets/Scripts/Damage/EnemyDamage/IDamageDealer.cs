using UnityEngine;

public interface IDamageDealer
{
    void TryDealDamage(Transform enemy, LifeBarController playerLife);
}
