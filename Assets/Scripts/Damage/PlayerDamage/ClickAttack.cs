using UnityEngine;

public class ClickAttack : MonoBehaviour, IAttackStrategy
{
    [SerializeField] private float attackRange = 1.5f;   // raio da área de ataque
    [SerializeField] private LayerMask enemyLayer;       // layer dos inimigos
    private EnemyLifeBarController currentTarget;

    // Implementação do contrato
    public void Attack(EnemyLifeBarController target)
    {
        if (target != null)
        {
            float damage = 10f;
            target.ModifyValue(-damage);
            Debug.Log("Ataque realizado! Dano: " + damage);
        }
    }

    // Atualiza constantemente se há inimigos na área
    private void Update()
    {
        Collider2D enemyCollider = Physics2D.OverlapCircle(transform.position, attackRange, enemyLayer);

        if (enemyCollider != null)
        {
            currentTarget = enemyCollider.GetComponent<EnemyLifeBarController>();

            // repassa para o Player
            GetComponentInParent<PlayerAttackController>().SetTarget(currentTarget);

            Debug.Log("Inimigo dentro da área de ataque!");
        }
        else
        {
            currentTarget = null;
            GetComponentInParent<PlayerAttackController>().ClearTarget();
        }
    }

    // Getter para o controlador acessar
    public EnemyLifeBarController GetCurrentTarget()
    {
        return currentTarget;
    }

    // Gizmo para visualizar a área no editor
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
