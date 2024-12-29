using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }

        if (other.CompareTag("Collactable"))
        {
            other.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;
        }
        else
        {
            speed = 10;
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
        //transform.position += direction * speed * Time.deltaTime;

    }
}
