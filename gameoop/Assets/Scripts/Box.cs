using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2;
    private Rigidbody _rb;
    void Start()
    {
        _rb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;

        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        _rb.velocity = direction.normalized * speed;
        //transform.position +=  direction  * speed * Time.deltaTime;

    }
}
