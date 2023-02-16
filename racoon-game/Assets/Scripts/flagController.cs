using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class flagController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        RacoonController controller = other.GetComponent<RacoonController>();
        if (controller != null)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
}
