using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDeathSceneChanger : MonoBehaviour
{
    [Tooltip("Nome da cena que será carregada quando o Boss morrer")]
    public string nextSceneName = "ProximaCena";

    private void OnEnable()
    {
        BossVida.OnBossKilled += ChangeScene;
    }

    private void OnDisable()
    {
        BossVida.OnBossKilled -= ChangeScene;
    }

    private void ChangeScene(BossVida boss)
    {
        Debug.Log("Boss derrotado! Carregando próxima cena...");
        SceneManager.LoadScene("Vitoria");
    }
}
