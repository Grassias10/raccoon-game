using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class areaSelection : MonoBehaviour
{
    public void BackToMM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
