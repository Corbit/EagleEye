using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour


{
    private Rigidbody2D rb;
    private int bulletTimer = 1700;
    Vector3 lastVelocity;
    public AudioSource tickSource;
    public int durability;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        tickSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        lastVelocity = rb.velocity;
        bulletTimer--;
        if (bulletTimer == 0)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Base")
        {
            if (durability < 2)
            {
                var speed = lastVelocity.magnitude;
                var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

                rb.velocity = direction * Mathf.Max(speed, 0.2f);
                durability++;
            }
            else { Destroy(gameObject); }
        }
        else if (collision.gameObject.tag == "Player")
        {
            // Game Over
        }
        else if (collision.gameObject.tag == "Target_Hit")
        {
            Destroy(collision.gameObject);
            tickSource.Play();
        }
        else if (collision.gameObject.tag == "Friendly")
        {
            //Game Over
        }
    }
}