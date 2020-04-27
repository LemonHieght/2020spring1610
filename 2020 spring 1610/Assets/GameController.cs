using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool gameHasEnded = false;
    private bool gameHasWon = false;
    public GameObject gameOverUI;
    public IntData score;
    public GameObject gameWonUI;

    void start()
    {
        gameHasWon = false;
    }

    public void WonGame()
    {
        if (gameHasWon == false)
        {
            gameHasWon = true;
            Debug.Log("game complete");
            Victory();
        }
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            GameOver();
            score.value = 0;

        }
    }

    void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    void Victory()
    {
        gameWonUI.SetActive(true);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void MenuStart()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
