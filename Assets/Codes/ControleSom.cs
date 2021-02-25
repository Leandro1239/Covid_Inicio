using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleSom : MonoBehaviour
{
    public GameObject on, off;
    
    private void Start()
    {
        if (Sons.SonsInstance.Musica.isPlaying){
            on.SetActive(true);
            off.SetActive(false);
        }
        else{
            off.SetActive(true);
            on.SetActive(false);
        }
    }


    // Update is called once per frame
    public void Ativa_Desativa()
    {
        if (Sons.SonsInstance.Musica.isPlaying){
            Sons.SonsInstance.Musica.Pause();
            off.SetActive(true);
            on.SetActive(false);
        }
        else{
            Sons.SonsInstance.Musica.Play();
            on.SetActive(true);
            off.SetActive(false);
        }
    }
}
