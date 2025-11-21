using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public static void LoadScene(int index)
    {
        if (index < 0)
        {
            Debug.LogError("Índice de cena inválido.");
            return;
        }

        SceneManager.LoadScene(index);
    }

    public static void LoadSceneByName(string sceneName)
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogError("Nome da cena inválido.");
            return;
        }

        SceneManager.LoadScene(sceneName);
    }
}
