using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;

    void OnEnable() {
        Vida.OnPlayerDeath += gameOver; 
    }

    void OnDisable() {
        Vida.OnPlayerDeath -= gameOver; 
    }

    public void gameOver(){
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Tela de Game Over ativada!");
    }

    public void restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void MainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Play(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
}
