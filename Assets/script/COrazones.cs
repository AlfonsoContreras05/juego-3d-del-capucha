using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COrazones : MonoBehaviour
{
    public GameObject[] Sandias;
    public Queue<GameObject> SandiasCola = new Queue<GameObject>();
    public static COrazones sandias;



    void Start()
    {

        sandias = this;
        foreach (GameObject g in Sandias)
        {
            SandiasCola.Enqueue (g);
            g.gameObject.SetActive (true);
        }

    }

    // Update is called once per frame

    void Update()

    {

    }
    public void reducirSandia()
    {
        GameObject g = SandiasCola.Dequeue ();
        g.gameObject.SetActive (false);
        SandiasCola.Enqueue (g);
    }

}