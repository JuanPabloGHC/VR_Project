using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    private bool onEndPoint;
    public GameObject panelIndicaciones;

    // Start is called before the first frame update
    void Start()
    {
        onEndPoint = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!onEndPoint)
        {
            panelIndicaciones.SetActive(true);
        }
        else
        {
            panelIndicaciones.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PuntoFinal")
        {
            onEndPoint = true;
        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PuntoFinal")
        {
            onEndPoint = true;
        }
    }
    */
}
