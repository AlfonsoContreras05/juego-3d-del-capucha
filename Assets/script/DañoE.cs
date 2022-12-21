using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoE : MonoBehaviour
{
    
    public int damage;
    public GameObject Player;
   

    private void OnTriggerEnter(Collider obj)
    {
        if(obj.CompareTag("Player"))
        {
            Player.GetComponent<VidaLucho>().vidaPlayer -= damage;
        }
        if(obj.CompareTag("Fruit")){
            Debug.Log("Yummy");
            Player.GetComponent<VidaLucho>().vidaPlayer += damage;
            Destroy(obj.gameObject);
        }


        
        
        
    }

}