using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    public Transform jugador;
    public Transform arbol;
    public Transform target;
    public DisparoEnemigo disparoEnemigo;
    public VidaJugador vidaJugadorActual;
    public TreeLife treeLifeActual;

    Vector3 direction;

    float velRotacion = 10f;
    float velCaza = 2f;
    public float rangoDisparo;
    float tiempoDisparo = 2f;
    float proximoDisparo;

    private void Start()
    {
        jugador = GameObject.Find("Player").transform;
        arbol = GameObject.Find("Rbolito").transform;
    }
    // Update is called once per frame
    void Update()
    {
        if ((jugador.transform.position - this.transform.position).magnitude > (arbol.transform.position-this.transform.position).magnitude)
        {
            target =arbol;
            
        }
        else
        {
            target = jugador;
        }

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), velRotacion*Time.deltaTime);
        
        direction = target.position - this.transform.position;

        //transform.Translate(direction.normalized*velCaza*Time.deltaTime);

        if (Vector3.Distance(target.position, this.transform.position)<rangoDisparo && (target == jugador))
        {
            if ((jugador.transform.position - this.transform.position).magnitude <= 1 && (target == jugador))
            {
                velCaza = 0f;
                AtacarMeleeJugador();
            }
            else
            {
                Invoke("Disparar", 1f);
                velCaza = 2f;
            }

            
        }
        else 
        {

            this.transform.Translate(0, 0, velCaza * Time.deltaTime);
          
        }
        if ((arbol.transform.position - this.transform.position).magnitude <= 1 && (target == arbol))
        {
            velCaza = 0f;
            AtacarMeleeArbol();
        }
        else
        {
            velCaza = 2f;
        }
    }

    private void Disparar()
    {
     if (Time.time > proximoDisparo)
     {
        proximoDisparo = Time.time + tiempoDisparo;
        disparoEnemigo.Disparo();
     }   
    }
    private void AtacarMeleeJugador()
    {
        if (Time.time > proximoDisparo)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            VidaJugador.vida.vidaActual -= 30;
        }
    }
    private void AtacarMeleeArbol()
    {
        if (Time.time > proximoDisparo)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            treeLifeActual.vidaActual -= 5;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoDisparo);
    }
}
