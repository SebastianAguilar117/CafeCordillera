using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : MonoBehaviour
{
    public Transform jugador;
    public Transform arbol;
    public Transform target;
    public VidaJugador vidaJugadorActual;
    public TreeLife treeLifeActual;
    public GameObject bala;


    Vector3 direction;
    float velRotacion = 5f;
    float velCaza = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((jugador.transform.position - this.transform.position).magnitude > (arbol.transform.position - this.transform.position).magnitude)
        {
            target = arbol;

        }
        else
        {
            target = jugador;
        }
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), velRotacion * Time.deltaTime);

        direction = target.position - this.transform.position;

        if ((target.transform.position - this.transform.position).magnitude <= 1 )
        {
            velCaza = 0f;
            Instantiate(bala, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else
        {
            this.transform.Translate(0, 0, velCaza * Time.deltaTime);
        }
    }
}
