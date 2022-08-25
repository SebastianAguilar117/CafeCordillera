using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ObjetoSpawneado;
    public float TiempoCrearEnemigo;

    void Start()
    {
        InvokeRepeating("crearEnemigo", TiempoCrearEnemigo,TiempoCrearEnemigo);
    }


    public void crearEnemigo ()
    {
        Instantiate(ObjetoSpawneado, transform.position, transform.rotation);
    }





}
