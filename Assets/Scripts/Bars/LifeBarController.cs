using UnityEngine;

public class LifeBarController : StatBarController
{
    [SerializeField] private bool destroyOnDeath = true;

    protected override void UpdateBar()
    {
        base.UpdateBar();

        // Se a vida chegou a zero, dispara a morte
        if (currentValue <= 0f && destroyOnDeath)
        {
            HandleDeath();
        }
    }

    private void HandleDeath()
    {
        Debug.Log("Player morreu!");

        // Desativa o objeto do jogador (opcional)
        gameObject.SetActive(false);

        // Voltar ao menu principal
        SceneLoader.LoadSceneByName("Menu");
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
