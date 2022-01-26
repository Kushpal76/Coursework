using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    private void Start()
    {
        PauseMenu.SetActive(false);  //This hides the menu by default
    }

    private void Update()
    {
        //This checks if the "esc" button is pressed and if you are already paused
        if (Input.GetButtonDown("Cancel") && Time.timeScale == 1)
        {
            PauseGame();
        }
        else if (Input.GetButtonDown("Cancel") && Time.timeScale == 0)
        {
            ResumeGame();
        }
    }
    public void PauseGame()
    {
        PauseMenu.SetActive(true); //This shows the pause menu
        Time.timeScale = 0f; //Pauses the game
        AudioListener.pause = true; //Pauses the audio
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false); //This hides the pause menu
        Time.timeScale = 1f; //Restarts the game
        AudioListener.pause = false; //Restarts the audio
    }
}
