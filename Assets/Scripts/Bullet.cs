using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.transform.CompareTag("Enemy"))
        {
          
            Destroy(gameObject);
        }
    }
}
