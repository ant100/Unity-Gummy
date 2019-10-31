using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] string nextLevel = null;
    [SerializeField] string menuLevel = null;

    public void LoadNextLevel()
    {
        if (GameManager.gm)
            GameManager.gm.LevelComplete(nextLevel);
    }

    public void PauseGame()
    {
        //Debug.Log("click");
        if (GameManager.gm)
            GameManager.gm.PauseGame();
    }

    public void ReturnMenu()
    {
        Time.timeScale = 1f; // this unpauses the game action (ie. back to normal)
        if (GameManager.gm)
            GameManager.gm.ResetScore();
            GameManager.gm.LevelComplete(menuLevel);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
