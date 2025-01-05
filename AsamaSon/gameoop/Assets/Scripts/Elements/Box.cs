using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameDirector gameDirector;
    public float speed = 5;
    public bool isAppleCollected;
    private Rigidbody _rb;
    void Start()
    {
        
        _rb=GetComponent<Rigidbody>();
        
    }
    public void RestartPlayer()
    {
        gameObject.SetActive(true);
        _rb = GetComponent<Rigidbody>();
        _rb.position = Vector3.zero;
        isAppleCollected = false;

    }
    private void OnTriggerEnter(Collider other)
    {
      
        //tagi collectable olan objeye �arp�nca obje yok olur
        if (other.CompareTag("Collectable"))
            {
            other.gameObject.SetActive(false);
            gameDirector.levelManager.AppleCollected();
            //objeye de�dimizde true ya d�ner
            isAppleCollected = true;
        }
        //ana karakter objeye ula�t���nda d��manlar�n h�z� 0 olur
        if (other.CompareTag("Door") && isAppleCollected)
        {
            gameDirector.LevelComplated();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //tagi enemy olan objeye �arp�nca karakter yok olur
        if (collision.transform.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //tu�a bas�lmad���nda hareket etmez
        var direction = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 8;
        }
        //keycode ile belirtilen tu�lara bas�ld���nda hareket y�nlerini g�sterir ve hareket eder
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
        //ara y�nlerden birine giderken daha h�zl� gitmemesi i�in her y�ne e�it h�zla gidebilmek i�in
        _rb.velocity = direction.normalized * speed;
        //transform.position +=  direction  * speed * Time.deltaTime;

    }
}
