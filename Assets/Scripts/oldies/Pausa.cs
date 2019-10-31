using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PauseButton, PauseMenu;

    public void Pause()
    {
        PauseButton.SetActive(true);
        Time.timeScale=0;

    }
    public void Resume()
    {
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
}
