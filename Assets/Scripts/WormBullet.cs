using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormBullet : MonoBehaviour
{
    public Rigidbody rigidBody;
    public VidaJugador vidaJugadorActual;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.AddRelativeForce(Vector3.forward * 200);
        rigidBody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5f);

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            VidaJugador.vida.vidaActual -= 3;
            Debug.Log("VomitoPisado");
        }
        if (collision.transform.CompareTag("Floor"))
        {
            //Debug.Log("PisoTocado");
            rigidBody.velocity = Vector3.zero;
            rigidBody.angularVelocity = Vector3.zero;
            rigidBody.useGravity = false;
        }
    }
}
