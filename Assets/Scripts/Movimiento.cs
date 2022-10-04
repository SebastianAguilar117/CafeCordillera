using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    public float rotacion;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, velocidad * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0, rotacion * Time.deltaTime * Input.GetAxis("Horizontal"),0);

        if ((Input.GetAxis("Vertical") * Input.GetAxis("Vertical"))+(Input.GetAxis("Horizontal")* Input.GetAxis("Horizontal"))<0.01f)
        {
            rb.velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("SpiderWeb"))
        {
            Debug.Log("Jugador ralentizado");
            velocidad = 1;
            Invoke("ClearMovement", 2f);
        }
    }
    private void ClearMovement()
    {
        velocidad = 4;
    }
}
