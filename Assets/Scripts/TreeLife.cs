using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeLife : MonoBehaviour
{
    public float vidaMax;
    public float vidaActual;
    public GameObject[] objectsDesactivate;
    public GameObject GameOver;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaActual <= 0)
        {
            Destroy(gameObject);
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    [ContextMenu("Actualizar Graficos")]
    public void ActualizarGraficos()
    {
        int vidaAuxiliar=Mathf.RoundToInt(vidaActual/vidaMax*(objectsDesactivate.Length-1));
        for (int i = 0; i < objectsDesactivate.Length; i++)
        {
            objectsDesactivate[i].SetActive(i < vidaAuxiliar);
        }
    }
}
