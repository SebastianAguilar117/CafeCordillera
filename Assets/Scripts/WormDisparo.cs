using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormDisparo : MonoBehaviour
{
    public GameObject bala;

    public void Disparo()
    {
        Vomito();
        Invoke("Vomito", 0.1f);
        Invoke("Vomito", 0.2f);
    }

    void Vomito()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
