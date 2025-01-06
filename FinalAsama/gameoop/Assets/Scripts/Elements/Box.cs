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
      
        //tagi collectable olan objeye çarpýnca obje yok olur
        if (other.CompareTag("Collectable"))
            {
            other.gameObject.SetActive(false);
            gameDirector.levelManager.AppleCollected();
            //objeye deðdimizde true ya döner
            isAppleCollected = true;
        }
        //ana karakter objeye ulaþtýðýnda düþmanlarýn hýzý 0 olur
        if (other.CompareTag("Door") && isAppleCollected)
        {
            gameDirector.LevelComplated();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //tagi enemy olan objeye çarpýnca karakter yok olur
        if (collision.transform.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //tuþa basýlmadýðýnda hareket etmez
        var direction = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 8;
        }
        //keycode ile belirtilen tuþlara basýldýðýnda hareket yönlerini gösterir ve hareket eder
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
        //ara yönlerden birine giderken daha hýzlý gitmemesi için her yöne eþit hýzla gidebilmek için
        _rb.velocity = direction.normalized * speed;
        //transform.position +=  direction  * speed * Time.deltaTime;

    }
}
