using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWeb : MonoBehaviour
{
    public float velMovimiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * velMovimiento * Time.deltaTime);
        Destroy(gameObject, 5f);
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        /*if (collision.transform.CompareTag("Muro"))
        {

            Destroy(gameObject);
        }*/
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
