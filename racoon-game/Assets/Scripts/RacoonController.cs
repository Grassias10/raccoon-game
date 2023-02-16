using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacoonController : MonoBehaviour
{
    public int maxHealth = 1;
    public int currentHealth;

    public float jumpSpeed = 1f;
    public float speed = 2f;
    public float direction = 0f;
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f || direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        } else
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }

        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
    }
}
