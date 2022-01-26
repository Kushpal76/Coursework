using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision) //Checks for a collision
    {
        if (collision.gameObject.CompareTag("Trap")) //Check if player has hit a trap
        {
            body.bodyType = RigidbodyType2D.Static; //Freezes the player sprite
            System.Threading.Thread.Sleep(250); //Waits 250ms
            RestartLevel();
        }
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //This replaces the current scene with a new version of the level
    }
}