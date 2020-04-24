using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool gameHasEnded = false;
    public GameObject gameOverUI;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverUI.SetActive(true);
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
