using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform target;
    public TreeLife treeLifeActual;

    Vector3 direction;

    float velRotacion = 10f;
    float velCaza = 2f;
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

        if ((target.transform.position - this.transform.position).magnitude <= 2.5f)
        {
            AtacarMeleeArbol();
            velCaza = 0f;
        }
        else
        {
            this.transform.Translate(0, 0, velCaza * Time.deltaTime);
            velCaza = 2f;
        }
    }
    private void AtacarMeleeArbol()
    {
        if (Time.time > proximoDisparo)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            treeLifeActual.vidaActual -= 10;
            treeLifeActual.CrearHojas();
        }
    }
}
