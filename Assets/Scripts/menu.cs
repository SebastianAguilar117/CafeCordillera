using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour

{
    public GameObject opciones;
    public void PasarDeEscenada()
    {
        SceneManager.LoadScene("Yankee");
    }
    public void AbrirOpciones()
    {
        opciones.SetActive(true);
    }
    public void CerrarOpciones()
    {
        opciones.SetActive(false);
    }
}
