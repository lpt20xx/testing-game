using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSingleton : MonoBehaviour
{

    public static SceneManagerSingleton Instance{ get; private set; }
    public Scene currentScene;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        this.GetScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void GetScene()
    {
        this.currentScene = SceneManager.GetActiveScene();
    }

    public virtual void StartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public virtual void StartGameSceneMSingleton()
    {
        SceneManager.LoadScene("RunLevel1");
    }

    public virtual void QuitGameMSingleton()
    {
        Application.Quit();
    }
}
