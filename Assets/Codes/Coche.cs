using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : MonoBehaviour
{
    public float speed;
    public float positionX;
    private bool touched;
    private GameObject Persona;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (touched)
        {
            Persona.transform.position = new Vector3(positionX, Persona.transform.position.y, Persona.transform.position.z + speed);
            this.transform.position = new Vector3(positionX, Persona.transform.position.y - 1f, Persona.transform.position.z);
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "XR Origin" )
        {
            Persona = other.gameObject;
            this.transform.SetParent(Persona.transform);
            touched = true;
            
        }
        else
        {
            this.transform.SetParent(null);
            touched = false;
        }
        
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "XR Origin")
        {
            Persona = collision.gameObject;
            this.transform.SetParent(Persona.transform);
            touched = true;

        }
    }*/
}