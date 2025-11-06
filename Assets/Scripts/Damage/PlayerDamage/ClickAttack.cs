public class ClickAttack : IAttackStrategy
{
    public void Attack(StatBarController target)
    {
        if (target == null) return;

        float damage = 10f; // Dano fixo
        target.ModifyValue(-damage);
    }
}
