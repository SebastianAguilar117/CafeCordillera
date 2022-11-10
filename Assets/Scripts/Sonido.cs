using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sonido : MonoBehaviour

{
    [SerializeField] Slider volumen;
    void Start()
    {
        if (!PlayerPrefs.HasKey("volumenMusica"))
        {
            PlayerPrefs.SetFloat("volumenMusica", 1);
            cargar();
        }
        else
        {
            cargar();
        }
    }
    public void CambiarVolumen()
    {
        AudioListener.volume = volumen.value;
        guardar();
    }
    private void cargar()
    {
        volumen.value = PlayerPrefs.GetFloat("volumenMusica");
    }
    private void guardar() 
    {
        PlayerPrefs.SetFloat("volumenMusica", volumen.value);
    }
}
