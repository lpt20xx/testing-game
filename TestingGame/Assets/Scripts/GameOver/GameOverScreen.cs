using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Button retryButton;
    public Button mainMenuButton;
    // Start is called before the first frame update
    private void Start()
    {
       
    }
 
    // Update is called once per frame
    private void Update()
    {
        
    }

    public void RetryGame()
    {
        SceneManagerSingleton.Instance.RetryGameScene();
    }
}
