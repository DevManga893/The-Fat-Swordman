using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    private IAttackStrategy attackStrategy;
    private EnemyLifeBarController enemyTarget;

    private void Start()
    {
        // Obtém a estratégia do filho (sensor)
        attackStrategy = GetComponentInChildren<IAttackStrategy>();
    }

    public void SetTarget(EnemyLifeBarController target)
    {
        enemyTarget = target;
    }

    public void ClearTarget()
    {
        enemyTarget = null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && enemyTarget != null)
        {
            attackStrategy.Attack(enemyTarget);
        }
    }
}
