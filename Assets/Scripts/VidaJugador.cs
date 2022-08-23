using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VidaJugador : MonoBehaviour
{
    public Image Barradevida; 
    public float vidaMax;
    public float vidaActual;
    public static VidaJugador vida; 
    // Start is called before the first frame update
    void Start()
    {
        vida = this;
    }

    // Update is called once per frame
    void Update()
    {
        Barradevida.fillAmount = vidaActual / vidaMax;
        if(vidaActual <= 0){

        }
    }
}
