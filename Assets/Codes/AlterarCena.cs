using UnityEngine.SceneManagement;
using UnityEngine;

public class AlterarCena : MonoBehaviour
{
    public void Menu(){
        SceneManager.LoadScene("01_Menu");
    }

    public void Login(){
        SceneManager.LoadScene("02_Login");
    }

    public void Parabens(){
        SceneManager.LoadScene("07_Parabens");
    }

    public void Ranking(){
        SceneManager.LoadScene("02_Ranking");
    }



    public void Entrar(){
        /*  
        if(user.idade <= 15 && user.cidade == Belém){
            SceneManager.LoadScene("05_Menor15");
        }

        else if(user.idade >= 15 && user.cidade == Belém){
            SceneManager.LoadScene("06_Maior15");
        }
        */

        SceneManager.LoadScene("05_Menor15");
    }
}
