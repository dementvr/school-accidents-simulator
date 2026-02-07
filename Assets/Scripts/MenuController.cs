using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); 
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("SettingsScene"); 
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed"); 
    }
}