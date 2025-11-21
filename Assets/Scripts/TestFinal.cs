using UnityEngine;

public class TestFinal : MonoBehaviour
{
    [SerializeField] private MenuManager menuManager;

    private void Update()
    {
        // Verifica se ainda existem inimigos na cena
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0)
        {
            menuManager.GoToWinCamera();
        }
    }
}