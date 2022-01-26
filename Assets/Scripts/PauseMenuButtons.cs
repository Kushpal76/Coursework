using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : Pause //This inherits pause
{
    private void Start()
    {
        //This is here so it doesnt inherit Pause's start function
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("Start Menu");
        //This loads the start menu screen
        ResumeGame();
        //This resumes time and the audio
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //This loads the current scene again to reset it
        ResumeGame();
        //This resumes time and the audio
    }
    public void ResumeGameButton()
    {
        ResumeGame();
    }
}
