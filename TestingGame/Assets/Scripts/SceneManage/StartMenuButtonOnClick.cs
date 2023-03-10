using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuButtonOnClick : MonoBehaviour
{
    public Button playButton;
    public Button ourWebsiteButton;
    public Button storeButton;
    public Button creditsButton;
    public Button quitButton;

    public string Url;
    

    private void Start()
    {   
        this.GetButton();
    }

    private void GetButton()
    {
        //get start button
        this.playButton = GameObject.Find("PlayButton").GetComponent<Button>();
        this.playButton.onClick.AddListener(StartGame);

        this.ourWebsiteButton = GameObject.Find("OurWebsiteButton").GetComponent<Button>();
        this.ourWebsiteButton.onClick.AddListener(GoToOurWebsite);

        this.storeButton = GameObject.Find("StoreButton").GetComponent<Button>();
        this.storeButton.onClick.AddListener(GoToStore);

        this.creditsButton = GameObject.Find("CreditsButton").GetComponent<Button>();
        this.creditsButton.onClick.AddListener(GoToCredits);

        //get quit button
        this.quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        this.quitButton.onClick.AddListener(QuitGame);

    }
    private void StartGame()
    {
        SceneManagerSingleton.Instance.StartGameSceneMSingleton();
    }

    private void GoToOurWebsite()
    {
        Application.OpenURL(Url);
    }

    private void GoToStore()
    {

    }

    private void GoToCredits()
    {

    }

    public void QuitGame()
    {
        SceneManagerSingleton.Instance.QuitGameMSingleton();
    }
}
