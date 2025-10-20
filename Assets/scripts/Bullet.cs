using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        

        if (collision.gameObject.CompareTag("Inimigo"))
        {
            Debug.Log("Atingiu um inimigo!");


            VidaInimigo enemyHealth = collision.gameObject.GetComponent<VidaInimigo>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(1); 
            }

            BossVida bossHealth = collision.gameObject.GetComponent<BossVida>();
            if (bossHealth != null)
            {
                bossHealth.TakeDamage(1); 
            }
        }

        Destroy(gameObject);
    }
}
