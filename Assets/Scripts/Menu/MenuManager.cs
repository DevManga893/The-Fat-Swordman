using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Menus (opcional, caso use UI dentro do Canvas)")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject creditsMenu;

    private void Start()
    {
        // Se estiver na cena Menu, garante que inicia na tela principal
        if (mainMenu != null && creditsMenu != null)
            ShowMainMenu();
    }

    // ==========================
    //        TROCAR TELAS
    // ==========================

    public void ShowMainMenu()
    {
        if (mainMenu != null) mainMenu.SetActive(true);
        if (creditsMenu != null) creditsMenu.SetActive(false);
    }

    public void ShowCredits()
    {
        if (mainMenu != null) mainMenu.SetActive(false);
        if (creditsMenu != null) creditsMenu.SetActive(true);
    }

    // ==========================
    //        TROCAR CENAS
    // ==========================

    public void StartGame()
    {
        SceneLoader.LoadSceneByName("SampleScene");
    }

    public void OpenTutorial()
    {
        SceneLoader.LoadSceneByName("Tutorial");
    }

    public void OpenCreditos()
    {
        SceneLoader.LoadSceneByName("Creditos");
    }

    public void BackToMenu()
    {
        SceneLoader.LoadSceneByName("Menu");
    }

    public void GoToWinCamera()
    {
        SceneLoader.LoadSceneByName("Win");
    }

    // ==========================
    //       SAIR DO JOGO
    // ==========================

    public void QuitGame()
    {
#if UNITY_EDITOR
        // Faz o botão Quit funcionar dentro do Editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Fecha o jogo no build final
        Application.Quit();
#endif

        Debug.Log("Jogo encerrado.");
    }
}
