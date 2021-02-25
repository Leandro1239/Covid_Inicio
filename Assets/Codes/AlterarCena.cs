using UnityEngine.SceneManagement;
using UnityEngine;

public class AlterarCena : MonoBehaviour
{
    public void Menu(){
        SceneManager.LoadScene("01_Menu");
    }

    public void Entrar(){
        /*  
        if(user.idade <= 15 && user.cidade == Belém){
            SceneManager.LoadScene("02_Norte");
        }

        else if(user.idade >= 15 && user.cidade == Belém){
            SceneManager.LoadScene("06_Maior15");
        }
        */

        SceneManager.LoadScene("02_Norte");
    }
}
