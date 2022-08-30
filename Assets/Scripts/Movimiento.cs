using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    public float rotacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, velocidad * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0, rotacion * Time.deltaTime * Input.GetAxis("Horizontal"),0);
    }
}
