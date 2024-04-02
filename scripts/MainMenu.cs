using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;

  public void playButton()
    {
        SceneManager.LoadScene("mainmap");
    }
    public void quitButton()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
