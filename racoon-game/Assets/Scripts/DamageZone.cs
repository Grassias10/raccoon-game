using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RacoonController controller = other.GetComponent<RacoonController>();
        if(controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
