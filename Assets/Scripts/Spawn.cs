using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] puntoSpawn;
    public GameObject[] enemigos;
    public float TiempoCrearEnemigo;

    void Start()
    {
        InvokeRepeating("crearEnemigo", TiempoCrearEnemigo,TiempoCrearEnemigo);
    }


    public void crearEnemigo ()
    {
        int enemigoRandom = Random.Range(0, enemigos.Length);
        int randomSpawn = Random.Range(0, puntoSpawn.Length);
        Instantiate(enemigos[0], puntoSpawn[0].position, transform.rotation);
    }





}
