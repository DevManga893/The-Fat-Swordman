using UnityEngine;

public class LifeBarController : StatBarController
{
    [SerializeField] private bool destroyOnDeath = true;

    protected override void UpdateBar()
    {
        base.UpdateBar();

        if (currentValue <= 0f && destroyOnDeath)
        {
            HandleDeath();
        }
    }

    private void HandleDeath()
    {
        // Aqui você pode adicionar lógica de morte, animação, desativar o jogador, etc.
        Debug.Log("Player morreu!");
        gameObject.SetActive(false);
    }

    public override void ModifyValue(float amount)
    {
        base.ModifyValue(amount);
        UpdateBar();
    }

    public override void SetValue(float value)
    {
        base.SetValue(value);
        UpdateBar();
    }
}
