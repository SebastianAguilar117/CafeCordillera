using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimientoycamara : MonoBehaviour
{
    public GameObject cam;
    public GameObject campos;
    public float velocidad; 
    public float velRotacion;



    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.W)){
            transform.Translate (new Vector3 (0,0,velocidad * Time.deltaTime));
        }
        else{
            if (Input.GetKey(KeyCode.S)){
                transform.Translate (new Vector3 (0,0,-velocidad * Time.deltaTime));
            }
        }
        if (Input.GetKey (KeyCode.D)){
            //campos.transform.SetParent(null);
            transform.Rotate (new Vector3(0,velRotacion * Time.deltaTime,0));
            //campos.transform.SetParent(transform);
        }
        else{
            if (Input.GetKey(KeyCode.A)){
            //campos.transform.SetParent(null);
            transform.Rotate (new Vector3(0,-velRotacion * Time.deltaTime,0));
            //campos.transform.SetParent(transform);
            }
        }
        cam.transform.position = Vector3.Lerp (cam.transform.position, campos.transform.position,0.1f);
    

    }
}
