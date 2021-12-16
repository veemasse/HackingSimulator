using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;

    int cash = Interpreter.balance;
    float performance = Interpreter.performance;

    public GameObject pauseMenuUI;
    void Update()
    {
        if (Paused)
        {
            Pause();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                unPause();
            } else {
                Pause();
            }
        }
    }
    
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    public void unPause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }
}
