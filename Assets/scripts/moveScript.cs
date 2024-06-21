using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float X;
    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Sparrow").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        X = Input.GetAxisRaw("Horizontal");
        rb.AddForce(X * speed, 0, 0);

        
    }
}
