using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PasarDeEscenada()
    {
        SceneManager.LoadScene("Yankee");
    }
}
