using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject gameOveScreen;
    GameOverMenu gameOverMenu;

   [SerializeField] public GameObject pauseScreen;
    PauseMenu pauseMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu = GameObject.FindGameObjectWithTag("GameOver").GetComponent<GameOverMenu>();
        pauseMenu = GameObject.FindGameObjectWithTag("Pause").GetComponent<PauseMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!pauseMenu.IsPaused && !gameOverMenu.gameOver) {
            Time.timeScale = 1;

            pauseMenu.PauseUI.SetActive(false);
            gameOverMenu.uiGameOver.SetActive(false);
        }

        if(pauseMenu.IsPaused && !gameOverMenu.gameOver) {
            Time.timeScale = 0;

            pauseMenu.PauseUI.SetActive(true);
        }

        if(gameOverMenu.gameOver) {
            Time.timeScale = 0;

            gameOverMenu.uiGameOver.SetActive(true);
        }
    }

}
