using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rayos: Se genera el RayCast en la escena donde se detectan las colisiones con los objetos "Correcto1" y Correcto2"
//, guarda el scrip cambio de color para el archivo CambioDeColor.cs.
public class Rayos : MonoBehaviour
{

    private new Transform camera;
    private CambioDeColor Script;
    public float raydistancia;

    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.DrawRay(camera.position, camera.forward * raydistancia, Color.red);

        RaycastHit hit;

        if (Physics.Raycast(camera.position, camera.forward, out hit, raydistancia, LayerMask.GetMask("Interactivo")))
        {

            if (hit.collider != null)
            {
                Script = hit.collider.gameObject.GetComponent<CambioDeColor>(); 
                if (Script != null)
                {
                    Script.teVeo(true);
                    
                }
            }
        }
        else
        {
            if(Script != null)
            {
                Script.teVeo(false);
            }
        }
    }
}
