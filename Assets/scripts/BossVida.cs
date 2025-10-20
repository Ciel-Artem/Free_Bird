using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BossVida : MonoBehaviour
{
    public static event Action<BossVida> OnBossKilled;
    [SerializeField] float health, maxHealth = 20;

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
            OnBossKilled?.Invoke(this);
        }
    }
}

