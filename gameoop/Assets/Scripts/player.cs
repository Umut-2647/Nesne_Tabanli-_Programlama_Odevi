using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.velocity =Vector3.forward*speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _rb.velocity = Vector3.back * speed;
        }
        else
        {
            _rb.velocity = Vector3.zero;
        }
    }
}
