using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasBullet : MonoBehaviour
{
    public float velMovimiento;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * velMovimiento * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Tree"))
        {
            Debug.Log("Tocar arbol");
        }
    }
}
