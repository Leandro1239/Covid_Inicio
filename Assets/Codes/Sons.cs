using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sons : MonoBehaviour
{
    public static Sons SonsInstance;
    public AudioSource Musica;

    // Start is called before the first frame update
    private void Awake()
    {
        if (SonsInstance != null && SonsInstance != this){
            Destroy(this.gameObject);
            return;
        }

        SonsInstance = this;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    private void Start()
    {
        Musica = GetComponent<AudioSource>();
    }
}
