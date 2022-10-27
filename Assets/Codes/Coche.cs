using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public float speed;
    private bool touched;
    private GameObject Persona;

    //Awake
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (touched)
        {
            this.transform.position = new Vector3(Persona.transform.position.x, Persona.transform.position.y - 1f, Persona.transform.position.z);
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