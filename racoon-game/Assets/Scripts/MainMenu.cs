using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelectionScene");
    }

    public void QuitGame()
    {
        Debug.Log("game quit");
        Application.Quit();
    }
}
