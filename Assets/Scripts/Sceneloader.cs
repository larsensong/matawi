using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Sceneloader : MonoBehaviour
{
    
    public void LoadNext()
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentsceneindex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadAboutScene()
    {
        SceneManager.LoadScene("About");
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LoadHighscoresScene()
    {
        SceneManager.LoadScene("Highscores");
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("Play");
    }

     public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadSecondLevel()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadThirdLevel()
    {
        SceneManager.LoadScene("Level 3");
    }
}
