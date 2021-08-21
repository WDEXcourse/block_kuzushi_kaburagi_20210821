using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(3, 0, -10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
