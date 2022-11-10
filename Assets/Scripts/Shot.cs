using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bala;
    public GameObject gas;
    public GameObject gas2;
    public GameObject melee;
    public float tiempoDisparo = 0.005f;
    public float tiempoDisparoGas = 0.0001f;
    float proximoDisparo;
    int weaponType = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            weaponType = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            weaponType = 2;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            weaponType = 3;
        }


        if (Input.GetKey("space") && Time.time > proximoDisparo)
        {
            
            switch(weaponType)
            {
                case 1: MeleeAttack(); break;
                case 2: disparopa();break;
                case 3: GasAttack();break;
            }
            
        }
    }
    void disparopa()
    {
        proximoDisparo = Time.time + tiempoDisparo;
        Instantiate(bala, transform.position, transform.rotation);
    }
    void GasAttack()
    {
        proximoDisparo = Time.time + tiempoDisparoGas;
        Instantiate(gas, transform.position, transform.rotation);
        Instantiate(gas2, transform.position, transform.rotation);
    }
    void MeleeAttack()
    {
        proximoDisparo = Time.time + tiempoDisparo;
        Instantiate(melee, transform.position, transform.rotation);
    }
}
