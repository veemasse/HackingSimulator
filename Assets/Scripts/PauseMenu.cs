using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    
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
