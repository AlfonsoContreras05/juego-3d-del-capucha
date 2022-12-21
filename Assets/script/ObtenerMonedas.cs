using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtenerMonedas : MonoBehaviour
{
    public Text txtMonedas;
    public short Monedas;
    // Start is called before the first frame update
    void Start()
    {
        txtMonedas.text=GameController.Monedas.ToString();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider obj){
        if(obj.CompareTag("Coins"))
        {
            Debug.Log("Pow");
            Monedas ++;
            txtMonedas.text=Monedas.ToString();
            Destroy(obj.gameObject);

        }

    }
}