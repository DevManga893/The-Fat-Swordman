using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    [SerializeField] private StatBarController enemyTarget;

    private IAttackStrategy attackStrategy;

    private void Start()
    {
        attackStrategy = new ClickAttack();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && enemyTarget != null)
        {
            attackStrategy.Attack(enemyTarget);
        }
    }
}
