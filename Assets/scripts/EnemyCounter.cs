using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyCounterUI : MonoBehaviour
{

    public void Start(){
        counterText.text = "Inimigos mortos: 0 ";
    }


    public TextMeshProUGUI counterText;
    private int enemiesKilled = 0;

    private void OnEnable()
    {
        VidaInimigo.OnInimigoKilled += UpdateCounter;
    }

    private void OnDisable()
    {
        VidaInimigo.OnInimigoKilled -= UpdateCounter;
    }

    private void UpdateCounter(VidaInimigo enemy)
    {
        enemiesKilled++;
        counterText.text = "Inimigos mortos: " + enemiesKilled;

         if (enemiesKilled >= 10)
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        Debug.Log("Carregando próxima cena...");
        SceneManager.LoadScene("BossFinal");
    
    }
}
