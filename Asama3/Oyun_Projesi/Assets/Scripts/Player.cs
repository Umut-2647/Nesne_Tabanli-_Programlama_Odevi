using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector3.right * speed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
        
    }
}
