using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class AlterarCena : MonoBehaviour
{
    public Text label;

    public void Menu(){
        SceneManager.LoadScene("01_Menu");
    }

    public void Entrar(){
        if (label.text == "Norte"){
            SceneManager.LoadScene("02_Norte");
        }
        if (label.text == "Sul"){
            SceneManager.LoadScene("03_Sul");
        }
        if (label.text == "Centro-Oeste"){
            SceneManager.LoadScene("05_Centro-Oeste");
        }
        if (label.text == "Sudeste"){
            SceneManager.LoadScene("06_Sudeste");
        }
        if (label.text == "Nordeste"){
            SceneManager.LoadScene("04_Nordeste");
        }
    }
}
