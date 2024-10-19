using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  void Update()
    {
        // elevar el objeto en el la posicion Y DESDE 0.5 HASTA 3 Y LUEGO REGRESAR A 0.5 Y REPETIR
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 0.5f, 3) + 0.5f, transform.position.z);

    }
}
