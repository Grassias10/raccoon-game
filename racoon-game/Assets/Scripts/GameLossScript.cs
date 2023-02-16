using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLossScript : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void playAgain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
