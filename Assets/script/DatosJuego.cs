using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DatosJuego : MonoBehaviour
{
    // Start is called before the first frame update

    public static DatosJuego datosJuego;
    public int puntaje;
    public Text textPuntaje, textNombre;

    private String rutaJuego;

    private void Awake() {
        rutaJuego=Application.persistentDataPath + "/datos.dat";

        if(datosJuego==null){
            datosJuego = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(datosJuego!=this){
            Destroy(gameObject);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Guardar(){
        //BinaryFormatter bf = new BinaryFormatter();
        //FileStream file = new FileStream(rutaJuego);
        //Datos datos = new Datos();
        //datos.puntaje = puntaje;
        //file.Close();
    }

    void Cargar(){

    }
}

[Serializable]
class Datos{
    public int puntaje;
    public Text textPuntaje, textNombre;
}