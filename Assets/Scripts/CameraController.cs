using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Referencia al jugador
    public GameObject jugador;

    //Para registrar la distancia entre la camara y el jugador
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

        //Calculo la distancia entre la camara y el jugador
        offset = transform.position - jugador.transform.position;
        
    }

    // Se ejecuta cada frame, pero despues de que todos los objetos hayan sido procesados
    void LateUpdate()
    {
        //Actualizo la posicion de la camara
        transform.position = jugador.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
