using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VidaCor : MonoBehaviour
{
    public Sprite CorPos, CorNeg;
    Image ImagemCor;

    private void Awake(){
        ImagemCor = GetComponent<Image>();
    }

    public void SetImageCor(StatusCor status){
        switch (status){
            case StatusCor.Neg:
                ImagemCor.sprite = CorNeg;
                break;
            case StatusCor.Pos:
                ImagemCor.sprite = CorPos;
                break;
        }
    }
}

public enum StatusCor{
    Neg=0,
    Pos=1
}