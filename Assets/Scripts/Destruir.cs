using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    // int vida =5;
    //public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "bullet")
        {
            Destroy(gameObject);
        }   
    }*/
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "CoffeeBullet")
        {
            //Instantiate(explosion, transform.position, transform.rotation);
            //vida--;
            //transform.position = new Vector3(Random.Range(-9, 9), 0.5f, Random.Range(-9, 9));
             Debug.Log("Le diste");
            Destroy(gameObject);
            Destroy(other.collider.gameObject);

            // Score.puntaje.SumarPuntos();

            // if (vida==0)
            // {
            //  Destroy(gameObject);
            // }
        }
    }
}
