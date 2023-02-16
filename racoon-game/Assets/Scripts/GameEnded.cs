using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnded : MonoBehaviour
{
    public Text levelStatus;
    public Text winStatus;

    public void mainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void playAgain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
