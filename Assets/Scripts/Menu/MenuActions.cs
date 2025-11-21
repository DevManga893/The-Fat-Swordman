using UnityEngine;

public static class MenuActions
{
    public static void StartGame()
    {
        // Ex: carregar a cena 1 (jogo)
        SceneLoader.LoadScene(1);
    }

    public static void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }

    public static void OpenCredits(MenuManager manager)
    {
        manager.ShowCredits();
    }
}
