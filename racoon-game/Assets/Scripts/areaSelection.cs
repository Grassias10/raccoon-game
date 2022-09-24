using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaSelection : MonoBehaviour
{
    public void BackToMM()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("MainScene");
    }
}
