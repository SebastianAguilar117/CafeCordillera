using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoV2 : MonoBehaviour
{
    public float speed;
    private Rigidbody playerRb;
    private Vector3 movement;
    public float velocidad;
    public Animator animator;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

          if(movement != new Vector3(0, 0, 0))
          {
              animator.SetBool("itsRunning", true);
          }
          else
          {
              animator.SetBool("itsRunning", false);
          }

        MoverJugador();
    }

    private void FixedUpdate()
    {
        MoverJugador();
        if (movement != new Vector3(0, 0, 0))
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
        else
        {
            RotarJugador();
        }
        
    } 

    void MoverJugador()
    {
      playerRb.MovePosition(transform.position + movement * speed * Time.deltaTime);
        
    }

    void RotarJugador()
    {
        Vector3 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        Vector3 direction = mouseOnScreen - positionOnScreen;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("SpiderWeb"))
        {
           // Debug.Log("Jugador ralentizado");
            velocidad = 1;
            Invoke("ClearMovement", 2f);
        }
    }
}
