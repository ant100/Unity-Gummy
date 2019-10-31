using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    [SerializeField]
    private string nextLevel = null;
    [SerializeField] GameObject UIGamePaused = null;

    private static int socialScore = 0;
    private static int emotionalScore = 0;
    [HideInInspector]
    public int difference;   

    private void Awake()
    {
        // setup reference to game manager
        if (gm == null)
            gm = this.GetComponent<GameManager>();
    }

    private void Update()
    {
        // if ESC pressed then pause the game
        if (Input.GetKeyDown(KeyCode.Escape))
            PauseGame();
    }

    public void PauseGame()
    {
        if (Time.timeScale > 0f)
        {
            UIGamePaused.SetActive(true); // this brings up the pause UI
            Time.timeScale = 0f; // this pauses the game action
        }
        else
        {
            Time.timeScale = 1f; // this unpauses the game action (ie. back to normal)
            UIGamePaused.SetActive(false); // remove the pause UI
        }
    }

    public void AddSocialPoints(int sPoints)
    {
        socialScore += sPoints;
        //Debug.Log( "Social Score: " + socialScore);
    }

    public void AddEmotionalPoints(int ePoints)
    {
        emotionalScore += ePoints;
        //Debug.Log( "Emotional Score: " + emotionalScore);
    }

    public int GetEmotionalScore()
    {
        return emotionalScore;
    }

    public int GetSocialScore()
    {
        return socialScore;
    }

    public int CalculateDifference()
    {
        return emotionalScore - socialScore;
    }

    public void LevelComplete(string nextLevelArg = null)
    {
        if (nextLevelArg != null)
            nextLevel = nextLevelArg;

        StartCoroutine(LoadNextLevel());
    }

    public void DrawScoreBar()
    {
        GameObject.Find("Score Bar").GetComponent<ScoreBarRenderer>().DrawScoreBar();
    }

    public void ResetScore()
    {
        socialScore = 0;
        emotionalScore = 0;
        GameObject.Find("Score Bar").GetComponent<ScoreBarRenderer>().DrawScoreBar();
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextLevel);
    }

    private void OnEnable()
    {
        GameObject.Find("Score Bar").GetComponent<ScoreBarRenderer>().DrawScoreBar();
    }
}
