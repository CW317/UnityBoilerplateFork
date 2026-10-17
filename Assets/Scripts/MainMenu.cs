using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GoToLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
