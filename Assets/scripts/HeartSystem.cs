using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject  CorPrefab;
    public Vida VidaJogador;
    List<VidaCor> Cor = new List<VidaCor>();

    private void Start(){
        DrawCor();
    }

    
    private void OnEnable() {
        Vida.OnPlayerDamaged += DrawCor;
    }

    private void OnDisable() {
        Vida.OnPlayerDamaged -= DrawCor;
    }

    public void DrawCor(){
        ClearCor();

        int CorPraFazer = (int)(VidaJogador.VidaMax);
        for (int i = 0; i < CorPraFazer; i++){
            CreateCorNeg();
        }

        for(int i = 0; i < Cor.Count; i++){
            int StatusCorRemainder = (int)Mathf.Clamp(VidaJogador.VidaAgr - (i),0,1);
            Cor[i].SetImageCor((StatusCor)StatusCorRemainder);
        }
    }

    public void CreateCorNeg(){
        GameObject newCor = Instantiate(CorPrefab);
        newCor.transform.SetParent(transform);

        VidaCor CorComponent = newCor.GetComponent<VidaCor>();
        CorComponent.SetImageCor(StatusCor.Neg);
        Cor.Add(CorComponent);
    }




    public void ClearCor(){
        foreach(Transform t in transform){
            Destroy(t.gameObject);
        }
        Cor = new List<VidaCor>();
    }



}
