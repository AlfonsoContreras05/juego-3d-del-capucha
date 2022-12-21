using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class ValidarDatos : MonoBehaviour
{
    public Text CajaNombre,CajaEdad;
    string Nombre {get;set;}
    byte Edad {get;set;}
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Validar(){
        Nombre = CajaNombre.text;
        try{
            Edad = byte.Parse(CajaEdad.text);
           // byte.TryParse(CajaEdad.text,out Edad);
        }
        catch(Exception ex){
            Debug.Log("Error edad no valida" + ex.Message);
        }

        SceneManager.LoadScene("Inicio");
        Debug.Log("El valor es"+Edad);
    }
}
