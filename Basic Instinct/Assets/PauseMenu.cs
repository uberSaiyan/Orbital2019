﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {
    public static bool isPaused;
    public GameObject pausePanel;
    public GameObject gameUI;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                resumeGame();
            }
            else {
                pauseGame();
            }
        }
    }

    void pauseGame() {
        // Freeze game
        Time.timeScale = 0f;
        // Hide Game UI
        gameUI.SetActive(false);
        // Bring up pause panel
        pausePanel.SetActive(true);
        // Set static variable for other scripts
        isPaused = true;
    }

    public void resumeGame() {
        // Unfreeze game
        Time.timeScale = 1f;
        // Bring up Game UI
        gameUI.SetActive(true);
        // Hide pause panel
        pausePanel.SetActive(false);
        // Set static variable
        isPaused = false;
    }

    public void loadMenu() {
        SceneManager.LoadScene(0);
    }

    public void quitGame() {
        Debug.Log("Exiting game.");
        Application.Quit();
    }
}
