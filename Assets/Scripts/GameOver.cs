using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    private bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver && GameObject.FindGameObjectWithTag("Player") == null)
        {
            SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.GameOver);
            gameOverPanel.SetActive(true);
            isGameOver = true;
            // Stop the game
            Time.timeScale = 0f;
        }
    }

    public void Restart()
    {
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Resume the game
        Time.timeScale = 1f;
    }

    public void Home()
    {
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
        SceneManager.LoadScene(0);
        // Resume the game
        Time.timeScale = 1f;
    }
}
