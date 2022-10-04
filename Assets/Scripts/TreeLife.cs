using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLife : MonoBehaviour
{
    public float vidaMax;
    public float vidaActual;
    public GameObject[] objectsDesactivate;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaActual <= 0)
        {
            Destroy(gameObject);
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
