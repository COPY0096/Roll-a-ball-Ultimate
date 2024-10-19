using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotar el objeto en el eje X, Y y Z
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

    }
}
