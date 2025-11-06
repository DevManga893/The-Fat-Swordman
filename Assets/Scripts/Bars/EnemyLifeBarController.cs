public class EnemyLifeBarController : StatBarController
{
    protected override void UpdateBar()
    {
        base.UpdateBar();

        if (currentValue <= 0f)
        {
            HandleDeath();
        }
    }

    private void HandleDeath()
    {
        print("Inimigo derrotado!");
        gameObject.SetActive(false);
    }
}
