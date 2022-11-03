using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //SceneManager.LoadScene("Game");
        Debug.Log("PLAY!");
    }

    public void OpenDebugA()
    {
        SceneManager.LoadScene("DebugA");
    }

    public void OpenDebugB()
    {
        SceneManager.LoadScene("DebugB");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
