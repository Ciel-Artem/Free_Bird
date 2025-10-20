using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VidaInimigo : MonoBehaviour
{
    public static event Action<VidaInimigo> OnInimigoKilled;
    [SerializeField] float health, maxHealth = 3f;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount; // 3 -> 2 -> 1 -> 0 => Enemy Has Died

        if (health <= 0)
        {
            Destroy(gameObject);
            OnInimigoKilled?.Invoke(this);
        }
    }
}

