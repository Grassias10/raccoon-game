using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DamageZone : MonoBehaviour
{
    //public GameEnded GameEnded;

    void OnTriggerEnter2D(Collider2D other)
    {
        RacoonController controller = other.GetComponent<RacoonController>();
        if(controller != null)
        {
            SceneManager.LoadScene("GameLoss");
        }
    }
}
