using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Perguntas : MonoBehaviour
{
    public float A, B;
    public GameObject certo, errado;


    public void Alternativa_A(){
        A = 1;
        B = 0;

    }

    public void Alternativa_B(){
        A = 0;
        B = 1;

    }

    public void Respondeu_1(){  //B é a certa
        if (A == 1){
            certo.SetActive(false);
            errado.SetActive(true);
        }
        if (B == 1){
            certo.SetActive(true);
            errado.SetActive(false);
        }
    }

    public void Respondeu_2(){  //A é a certa
        if (A == 1){
            certo.SetActive(true);
            errado.SetActive(false);
        }
        if (B == 1){
            certo.SetActive(false);
            errado.SetActive(true);
        }
    }
    
    public void Respondeu_3(){  //A é a certa
        if (A == 1){
            certo.SetActive(true);
            errado.SetActive(false);
        }
        if (B == 1){
            certo.SetActive(false);
            errado.SetActive(true);
        }
    }

    public void Respondeu_4(){  //A é a certa
        if (A == 1){
            certo.SetActive(true);
            errado.SetActive(false);
        }
        if (B == 1){
            certo.SetActive(false);
            errado.SetActive(true);
        }
    }

    public void Respondeu_5(){  //B é a certa
        if (A == 1){
            certo.SetActive(false);
            errado.SetActive(true);
        }
        if (B == 1){
            certo.SetActive(true);
            errado.SetActive(false);
        }
    }
}
