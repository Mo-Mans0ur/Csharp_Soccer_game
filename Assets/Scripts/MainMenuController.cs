using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Button newGameButton;
    public Button exitButton;

    void Start()
    {
        newGameButton.onClick.AddListener(() => LoadNewGame());
        exitButton.onClick.AddListener(ExitGame);
    }

    void LoadNewGame()
    {
        SceneManager.LoadScene("Level1");
    }

    void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
