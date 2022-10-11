using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cambio de Color: cambia el color de los objetos "Correcto1" y "Correcto2" cuando el RayCast colisiona con 
//los objetos cambiandolos de color a verde

public class CambioDeColor : MonoBehaviour
{

    public Color defaultColor;
    public Color newcolor;
    public Renderer render;
   

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }


    public void teVeo(bool Collision)
    {
        if (Collision)
        {
            render.material.color = newcolor;
           
        }
        else
        {
            render.material.color = defaultColor;
            
        }
       
    }


    

}
