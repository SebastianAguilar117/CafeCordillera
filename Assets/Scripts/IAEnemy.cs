using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    public Transform jugador;
    public Transform arbol;
    public Transform target;
    public DisparoEnemigo disparoEnemigo;

    Vector3 direction;

    float velRotacion = 10f;
    float velCaza = 2f;
    public float rangoDisparo;
    float tiempoDisparo = 2f;
    float proximoDisparo;
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
            

            Invoke("Disparar", 1f);
        }
        else 
        {
            this.transform.Translate(0, 0, velCaza * Time.deltaTime);
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
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoDisparo);
    }
}
