using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] private StatBarController barraDeVida; // Referência à barra de vida do inimigo
    private bool estaMorto = false;

    void Update()
    {
        if (!estaMorto && barraDeVida != null && barraDeVida.GetValue() <= 0f)
        {
            Morrer();
        }
    }

    void Morrer()
    {
        estaMorto = true;
        Destroy(gameObject);
    }
}
