using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaLucho : MonoBehaviour
{
    public int vidaPlayer =100;
    public Slider vidaVisual;
    public int corazones = 3;
    public int vidaPublic;
    
    // Start is called before the first frame update

    void Start()
    {
        vidaPublic = corazones;
    }


    // Update is called once per frame
    void Update()
    {

        vidaVisual.GetComponent<Slider>().value=vidaPlayer;
        if(vidaPlayer<=0)
        {
            vidaPlayer = 100;
            corazones-= 1;

            if (COrazones.sandias != null)
            {
                COrazones.sandias.reducirSandia ();

            }

            if (corazones <= 0)
            {
                SceneManager.LoadScene("Pantallaresultado");
            }
        }

    }
}