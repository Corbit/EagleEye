using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    GameOverMenu gameOverMenu;
    PauseMenu pauseMenu;
    WinMenu winMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu = GameObject.FindGameObjectWithTag("GameOver").GetComponent<GameOverMenu>();
        pauseMenu = GameObject.FindGameObjectWithTag("Pause").GetComponent<PauseMenu>();
        winMenu = GameObject.FindGameObjectWithTag("Win").GetComponent<WinMenu>();
    }

    // Update is called once per frame
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

        if(gameOverMenu.gameOver) {
            Time.timeScale = 0;

            gameOverMenu.uiGameOver.SetActive(true);
        }

        if(winMenu.won && !gameOverMenu.gameOver && !pauseMenu.IsPaused) {
            Time.timeScale = 0;
            
            winMenu.uiWin.SetActive(true);
        }
    }

}
