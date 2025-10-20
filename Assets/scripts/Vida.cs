using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class Vida : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;


    private bool isDead;

    public GameManagerScript gameManager;
    
    public float VidaMax, VidaAgr;

    void Start(){
        VidaAgr = VidaMax;
    }

    public void TomarDano(float amount){
        VidaAgr -= amount;
        OnPlayerDamaged?.Invoke();

         if (VidaAgr <= 0 && !isDead){
        isDead = true;

        OnPlayerDeath?.Invoke(); 
        Debug.Log("Dead");
        }
    }
}
