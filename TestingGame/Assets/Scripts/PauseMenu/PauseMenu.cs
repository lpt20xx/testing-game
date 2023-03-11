using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public bool isPaused;

    // Start is called before the first frame update
    private void Start()
    {
        this.SetInactivePauseMenu();
    }

    private void SetInactivePauseMenu()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        this.PressPauseKey();
    }

    private void PressPauseKey()
    {
        if (PlayerMove.canMove == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }
        }
        
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManagerSingleton.Instance.StartMenu();
    }

    public void QuitGame()
    {
        SceneManagerSingleton.Instance.QuitGameMSingleton();
    }
}
