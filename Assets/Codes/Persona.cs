using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Persona : MonoBehaviour
{
    private bool onEndPoint;
    public GameObject panelIndicaciones;
    public TMP_Text distanciaTexto;
    public Transform puntoFinal;

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
            float dist = Vector3.Distance(puntoFinal.position, this.transform.position);
            int distExacta = (int)dist;
            distanciaTexto.text = distExacta.ToString() + " metros";
            panelIndicaciones.SetActive(true);
        }
        else
        {
            distanciaTexto.text = " ";
            panelIndicaciones.SetActive(false);
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PuntoFinal")
        {
            onEndPoint = true;
        }
        else
        {
            onEndPoint = false;
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
