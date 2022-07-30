using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script controlls the display of the diffrent UI screens.
*/

public class MenuController : MonoBehaviour
{
    GameOverMenu gameOverMenu;
    PauseMenu pauseMenu;
    WinMenu winMenu;
    
    // fetch the scripts for the diffrent screens
    void Start()
    {
        gameOverMenu = GameObject.FindGameObjectWithTag("GameOver").GetComponent<GameOverMenu>();
        pauseMenu = GameObject.FindGameObjectWithTag("Pause").GetComponent<PauseMenu>();
        winMenu = GameObject.FindGameObjectWithTag("Win").GetComponent<WinMenu>();
    }

    // handels that only one screen is displayed at the time and that the gametime is stopped and restartet properly
    void Update()
    {
        if(!pauseMenu.IsPaused && !gameOverMenu.gameOver && !winMenu.won) {
            Time.timeScale = 1;

            pauseMenu.PauseUI.SetActive(false);
            gameOverMenu.uiGameOver.SetActive(false);
            winMenu.uiWin.SetActive(false);
        }

        if(pauseMenu.IsPaused && !gameOverMenu.gameOver && !winMenu.won) {
            Time.timeScale = 0;

            pauseMenu.PauseUI.SetActive(true);
        }

        if(gameOverMenu.gameOver && !winMenu.won) {
            Time.timeScale = 0;

            gameOverMenu.uiGameOver.SetActive(true);
        }

        if(winMenu.won && !gameOverMenu.gameOver && !pauseMenu.IsPaused) {
            Time.timeScale = 0;
            
            winMenu.uiWin.SetActive(true);
        }
    }

}
