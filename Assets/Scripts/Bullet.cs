using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour


{
    private Rigidbody2D rb;
    private int bulletTimer = 700;
    Vector3 lastVelocity;
    public AudioSource tickSource;

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
        if (collision.gameObject.tag == "Obstacle")
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0.2f);
        }
        else if (collision.gameObject.tag == "Player")
        {
            // Game Over
        }
        else if (collision.gameObject.tag == "Enemy")
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