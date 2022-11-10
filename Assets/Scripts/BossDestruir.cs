using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDestruir : MonoBehaviour
{
    int vida = 10;
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
            vida -= 1;
            if (vida < 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.transform.CompareTag("Gas"))
        {
            vida -= 1;
            if(vida<1)
            {
                Destroy(gameObject);
            }
        }
    }
}
