using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VidaJugador : MonoBehaviour
{
   // public Image Barradevida; 
    public float vidaMax;
    public float vidaActual;
    public static VidaJugador vida;
    public Slider barradevida;
    
    // Start is called before the first frame update
    void Awake()
    {
        vida = this;
    }

    // Update is called once per frame
    void Update()
    {
       // Barradevida.fillAmount = vidaActual / vidaMax;
        if(vidaActual <= 0)
        {
            Destroy(gameObject);
        }
        barradevida.value = vidaActual / vidaMax;
    }
   
}
