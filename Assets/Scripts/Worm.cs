using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    public Transform target;
    public WormDisparo disparoEnemigoWorm;
    Vector3 direction;

    float velRotacion = 3f;
    float velCaza = 2f;
    public float rangoDisparo;
    float tiempoDisparo = 2f;
    float proximoDisparo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), velRotacion * Time.deltaTime);

        direction = target.position - this.transform.position;

        if ((target.transform.position - this.transform.position).magnitude <= rangoDisparo)
        {
            Invoke("Disparar", 1f);
            velCaza = 0f;
        }
        else
        {
            this.transform.Translate(0, 0, velCaza * Time.deltaTime);
            velCaza = 2f;
        }
    }
    private void Disparar()
    {
        if (Time.time > proximoDisparo)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            disparoEnemigoWorm.Disparo();
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoDisparo);
    }
}
