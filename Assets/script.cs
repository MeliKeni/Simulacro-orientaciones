using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombre;
    public int curso;
    public string orientacion;

    void Start()
    {
        if(nombre == "" || curso > 5 || curso < 1)
        {
            Debug.Log("Hay un error en el ingreso de datos");
        }else if (orientacion != "M" && orientacion != "T" && orientacion != "H" && orientacion != "D" && orientacion != "G")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        } else if (curso < 3)
        {
            Debug.Log("Error. Aun estas en ciclo basico");
        }else
        {
            Debug.Log("Muchas gracias " + nombre);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
