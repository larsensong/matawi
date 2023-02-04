using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

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
}
