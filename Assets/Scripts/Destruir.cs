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
   
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("CoffeeBullet"))
        {
            Debug.Log("Enemigo golpeado");
            Destroy(gameObject);
            Destroy(gameObject);
        }
    }

}
