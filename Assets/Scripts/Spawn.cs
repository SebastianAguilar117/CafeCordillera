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
        GameObject enemigo = Instantiate(enemigos[enemigoRandom], puntoSpawn[randomSpawn].position, transform.rotation);
        enemigo.GetComponent<IAEnemy>().treeLifeActual = GameObject.Find("Rbolito").GetComponent<TreeLife>();
    }





}
