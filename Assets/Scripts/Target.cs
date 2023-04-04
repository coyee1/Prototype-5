using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.Addforce(Vector3.up * Random.range(12, 16), ForceMode.Impulse)
        targetRb.Addtorque
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
