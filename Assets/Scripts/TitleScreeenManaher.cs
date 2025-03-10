using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGameScene");  // Replace with your actual scene name
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
