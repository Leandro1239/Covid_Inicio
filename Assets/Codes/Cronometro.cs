using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour{
    public Text cronometroText;
    private float contagem = 30.0f;
    
    void Update(){
        if (contagem > 0.0f){
            contagem -= Time.deltaTime;
            cronometroText.text = contagem.ToString("F2");
        }

        else
            cronometroText.text = "Acabou o tempo";
    }
}
