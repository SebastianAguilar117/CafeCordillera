using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public TreeLife treeLifeActual;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            VidaJugador.vida.vidaActual -= 30;
        }
        if (collision.transform.CompareTag("Tree"))
        {
            treeLifeActual.vidaActual -= 10;
        }
    }
}
