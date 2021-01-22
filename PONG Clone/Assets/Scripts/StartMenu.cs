using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject helpMenuUI;

    public void playGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void quitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    public void optionsScreen()
    {
        startMenuUI.SetActive(false);
        helpMenuUI.SetActive(true);
    }

    public void backToMainMenu()
    {
        helpMenuUI.SetActive(false);
        startMenuUI.SetActive(true);
    }
}
