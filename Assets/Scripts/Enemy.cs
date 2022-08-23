using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float radio;
    public LayerMask protagonista;
    public Transform jugador;
    public float distanciaMax;
    public float speed;
    bool alerta;
    public int enemy;
    public float ataque;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alerta = Physics.CheckSphere(transform.position, radio, protagonista);

        if (alerta == true)
        {
            transform.LookAt(new Vector3 (jugador.position.x,transform.position.y,jugador.position.z));
            if((jugador.position-transform.position).magnitude>distanciaMax){
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, transform.position.y, jugador.position.z), speed * Time.deltaTime);
            }
            
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radio);
    }
    public void OnTriggerStay(Collider Other){
        if(Other.CompareTag ("Player")){
            VidaJugador.vida.vidaActual -= ataque * Time.deltaTime;
        }
    }
}
