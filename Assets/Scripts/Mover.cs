using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float randomOffsetX;
    float randomOffsetZ;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize random offsets in Start method
        randomOffsetX = Random.Range(-0.1f, 0.1f);
        randomOffsetZ = Random.Range(-0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        // Update random offsets each frame
        randomOffsetX = Random.Range(-0.1f, 0.1f);
        randomOffsetZ = Random.Range(-0.1f, 0.1f);

        // Move the object in the X and Z axes randomly
        transform.position = new Vector3(transform.position.x + randomOffsetX, transform.position.y, transform.position.z + randomOffsetZ);
    }
}
