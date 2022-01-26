using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void OpenControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void OpenLeaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void OpenAccountScreen()
    {
        SceneManager.LoadScene("Account");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
